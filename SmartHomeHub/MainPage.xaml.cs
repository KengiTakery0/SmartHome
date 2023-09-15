using SmartHomeHub.Model;

namespace SmartHomeHub
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConectClicked(object sender, EventArgs e)
        {
            try
            {
                DataBaseConnector.filePath = "D:\\Work\\SmartHome\\SmartHomeHub\\DataBase\\Home.db";
                DataBaseConnector.Connect();
                //DataBaseConnector.CreateUser();
                GenerateMessage.ShowAlertOneOption(this, "Регистрация", "Пользователь Успешно Создан", "OK");
            }
            catch (Exception)
            {
                GenerateMessage.ShowAlertOneOption(this, "Регистрация", $"{e}\n попробуйте перзагрузить приложение", "OK");

                throw;
            }
        }
    }
}