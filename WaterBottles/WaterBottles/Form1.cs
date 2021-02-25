using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WaterBottles
{
    public partial class Form1 : Form
    {
        private List<PictureBox> PictureBoxes { get; set; }
        private List<Label> InformationLabels { get; set; }
        private int SelectedPictureId { get; set; }

        public Form1()
        {
            InitializeComponent();

            LoadPictureBoxes();
            LoadInformationLabels();
        }

        /// <summary>
        /// Получение url картинок и их отображение
        /// </summary>
        private void LoadPictureBoxes()
        {
            PictureBoxes = new List<PictureBox>
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4
            };

            var context = new WaterBottlesDataContextDataContext(Properties.Settings.Default.WaterBottlesConnectionString);
            var photoUrls = context.BottlePhoto.ToList();
            for (int i = 0; i < PictureBoxes.Count; i++)
            {
                PictureBoxes[i].ImageLocation = photoUrls[i].PhotoUrl;
            }
        }

        /// <summary>
        /// Заполнение данных по каждой бутыли
        /// </summary>
        private void LoadInformationLabels()
        {
            InformationLabels = new List<Label>
            {
                label1,
                label2,
                label3,
                label4
            };

            var context = new WaterBottlesDataContextDataContext(Properties.Settings.Default.WaterBottlesConnectionString);
            var bottles = context.Bottle.ToList();
            for (int i = 0; i < InformationLabels.Count; i++)
                InformationLabels[i].Text = GetBottleInformation(bottles[i]);
        }

        /// <summary>
        /// Обновление данных определенной бутыли
        /// </summary>
        /// <param name="selectedPictureId">Номер выбранной бутыли</param>
        private void UpdateInformationLabel(int selectedPictureId)
        {
            var context = new WaterBottlesDataContextDataContext(Properties.Settings.Default.WaterBottlesConnectionString);
            var bottles = context.Bottle.ToList();
            int labelId = selectedPictureId - 1;
            InformationLabels[labelId].Text = GetBottleInformation(bottles[labelId]);
        }

        /// <summary>
        /// Метод получения данных по бутыли
        /// </summary>
        /// <param name="bottle">Бутыль</param>
        /// <returns>Информация в виде full / all</returns>
        private string GetBottleInformation(Bottle bottle)
        {
            return $"{bottle.QuantityOfFull} / {bottle.Quantity}";
        }

        /// <summary>
        /// Сброс выделения картинки
        /// </summary>
        private void ResetSelect()
        {
            foreach (var pictureBox in PictureBoxes)
                pictureBox.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Заполнение поля описания бутыли
        /// </summary>
        /// <param name="selectedPictureId">Номер выбранной бутыли</param>
        private void SetBottleDescription(int selectedPictureId)
        {
            var context = new WaterBottlesDataContextDataContext(Properties.Settings.Default.WaterBottlesConnectionString);
            var bottles = context.Bottle.ToList();
            int bottleId = selectedPictureId - 1;
            bottleDescription.Text = $"{bottles[bottleId].Description}. " +
                $"Объем - {bottles[bottleId].BottleType.Volume} л.";
        }

        /// <summary>
        /// Метод выделения бутыли и настройка допустимых значений
        /// для NumericUpDown каждой бутыли
        /// </summary>
        /// <param name="sender">Выделенная картинка бутыли</param>
        private void SelectPictureBox(object sender)
        {
            ResetSelect();
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BackColor = Color.Red;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            SetNumericUsedWaterBottles(SelectedPictureId);
            SetNumericAddedWaterBottles(SelectedPictureId);

            SetBottleDescription(SelectedPictureId);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectedPictureId = 1;
            SelectPictureBox(sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SelectedPictureId = 2;
            SelectPictureBox(sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SelectedPictureId = 3;
            SelectPictureBox(sender);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SelectedPictureId = 4;
            SelectPictureBox(sender);
        }

        /// <summary>
        /// Установка допустимых значений для выбора бутылей
        /// для использования
        /// </summary>
        /// <param name="pictureId">Id выбранной бутыли</param>
        private void SetNumericUsedWaterBottles(int pictureId)
        {
            var context = new WaterBottlesDataContextDataContext(Properties.Settings.Default.WaterBottlesConnectionString);
            var bottle = context.Bottle.Where(x => x.BottleId == pictureId).First();
            usedWaterBottles.Maximum = bottle.QuantityOfFull;
        }

        /// <summary>
        /// Установка допустимых значений для выбора бутылей
        /// для добавления
        /// </summary>
        /// <param name="pictureId">Id выбранной бутыли</param>
        private void SetNumericAddedWaterBottles(int pictureId)
        {
            var context = new WaterBottlesDataContextDataContext(Properties.Settings.Default.WaterBottlesConnectionString);
            var bottle = context.Bottle.Where(x => x.BottleId == pictureId).First();
            addedWaterBottles.Maximum = bottle.Quantity - bottle.QuantityOfFull;
        }

        /// <summary>
        /// Действие при нажатии на кнопку "Израсходовать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useWaterButton_Click(object sender, EventArgs e)
        {
            if (SelectedPictureId == 0)
                ShowErrorMessage("Нет выбранной бутыли!");
            else
            {
                var context = new WaterBottlesDataContextDataContext(Properties.Settings.Default.WaterBottlesConnectionString);
                var bottle = context.Bottle.Where(x => x.BottleId == SelectedPictureId).First();

                if (bottle.QuantityOfFull == 0)
                    ShowErrorMessage("В наличии нет полных бутылей!");

                bottle.QuantityOfFull -= (int)usedWaterBottles.Value;
                context.SubmitChanges();

                UpdateInformationLabel(SelectedPictureId);

                SetNumericUsedWaterBottles(SelectedPictureId);
                SetNumericAddedWaterBottles(SelectedPictureId);
            }
            usedWaterBottles.Value = 0;
        }

        /// <summary>
        /// Действие при нажатии на кнопку "Пополнить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addWaterButton_Click(object sender, EventArgs e)
        {
            if (SelectedPictureId == 0)
                ShowErrorMessage("Нет выбранной бутыли!");
            else
            {
                var context = new WaterBottlesDataContextDataContext(Properties.Settings.Default.WaterBottlesConnectionString);
                var bottle = context.Bottle.Where(x => x.BottleId == SelectedPictureId).First();

                if (bottle.QuantityOfFull == bottle.Quantity)
                    ShowErrorMessage("Все бутыли полные!");

                bottle.QuantityOfFull += (int)addedWaterBottles.Value;
                context.SubmitChanges();
                
                UpdateInformationLabel(SelectedPictureId);

                SetNumericUsedWaterBottles(SelectedPictureId);
                SetNumericAddedWaterBottles(SelectedPictureId);
            }
            addedWaterBottles.Value = 0;
        }

        /// <summary>
        /// Показ ошибок приложения
        /// </summary>
        /// <param name="errorMessage">Текст ошибки</param>
        private void ShowErrorMessage(string errorMessage)
        {
            errorLabel.Text = errorMessage;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Visible = true;
            hideErrorButton.Visible = true;
        }

        /// <summary>
        /// Действие при нажатии на кнопку "Закрыть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hideErrorButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Visible = false;
            errorLabel.Text = string.Empty;
            errorLabel.Visible = false;
        }
    }
}
