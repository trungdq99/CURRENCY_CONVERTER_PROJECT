using System;

namespace CurrencyConverter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSay_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient serv = new ServiceReference1.WebService1SoapClient();
            string say = serv.HelloWorld();
            lbSay.Text = say;
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double from = double.Parse(txtFrom.Text);
                string fromCurrency = ddlFromCurrency.SelectedValue;
                string toCurrency = ddlToCurrency.SelectedValue;
                ServiceReference1.WebService1SoapClient serv = new ServiceReference1.WebService1SoapClient();
                double to = serv.Convert(from, fromCurrency, toCurrency);
                txtTo.Text = to.ToString();
            }
            catch
            {
                txtTo.Text = "You must input number";
            }
            

        }
    }
}