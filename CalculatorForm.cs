using BooleanAlgebra;

namespace WinForms_AAC_LogicCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            actionsLabel.Text = "Дизъюнкция — \"+\"\r\nКонъюнкция — \"*\"\r\nОтрицание — \"!\"\r\nЭквиваленция — \"~\"\r\nИмпликация — \">\" or \"<\"";
        }

        private void calcButton_Click_1(object sender, EventArgs e)
        {
            resultLabel.Text = "Результат";
            actionsLabel.Text = "";
            BooleanFunctions boolf = new BooleanFunctions();
            boolf.SetVariables(UILogic.variables, UILogic.values);
            try
            {
                List<string> actions = (RPN.Calculate(UILogic.getReplacedFormula(formulaEntry.Text), boolf));
                resultLabel.Text = actions.LastOrDefault();
                actions.Remove(actions.Last());
                foreach (string action in actions)
                {
                    actionsLabel.Text += (action.ToString());
                }
            }
            catch (Exception) 
            {
                resultLabel.Text = "Результат";
                actionsLabel.Text = "Дизъюнкция — \"+\"\r\nКонъюнкция — \"*\"\r\nОтрицание — \"!\"\r\nЭквиваленция — \"~\"\r\nИмпликация — \">\" or \"<\"";
                formulaEntry.Text = "Некорректный ввод";
            };
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }
    }
}