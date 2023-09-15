using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeHub.Model
{
    public static class GenerateMessage
    {

        public async static void ShowAlertOneOption(ContentPage page, string title, string message, string option)
        {
            await page.DisplayAlert(title, message, option);
        }
    }
}
