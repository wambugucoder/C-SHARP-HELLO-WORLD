using System.Windows.Forms;
public class ExampleForm : Form // inherits from System.Windows.Forms.Form
{
public static void Main()
{
ExampleForm wikibooksForm = new ExampleForm();
wikibooksForm.Text = "I Love Wikibooks";// specify title of the form
wikibooksForm.Width = 400; // width of the window in pixels
wikibooksForm.Height = 300; // height in pixels
Application.Run(wikibooksForm); // display the form
}
}