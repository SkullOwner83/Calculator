namespace Calculadora
{
	public partial class Calculadora : FormFather
	{
		//Declaraci�n de variables
		double CurrentNumber = 0, LastNumber = 0;
		bool EndOperation = false;
		int MaxLenght = 14;
		char Operator;

		#region Controles de inicializaci�n
		//Metodo Constructor
		public Calculadora()
		{
			InitializeComponent();  
        }

		//Cargar y establecer configuraci�n guardada
        private void LoadForm(object sender, EventArgs e)
        {
            tbx_screen.Text = "0";
        }
		#endregion
        #region Controles de entrada
        //Comprobaci�n de pulsado de botones
        private void ClickButtonFunction(object sender, EventArgs e)
		{
			//Guardar el objeto que llam� al evento para poder acceder a sus propiedades
			var ButtonPress = ((Button)sender);

			//Comprobar si el boton es numerico o de funci�n
			if (ButtonPress.Text.All(char.IsNumber))
			{
				AddNumbersOnScreen(ButtonPress.Text);
			}
			else
			{
				PerformOperation(ButtonPress.Name, ButtonPress.Text);
			}
		}

		//Metodo de comprobaci�n de teclas
		private void KeyPressFunction(object sender, KeyPressEventArgs e)
        {
			string KeyPress = Convert.ToString(e.KeyChar), Operation = "";

			//Comprobar si la tecla pulsada es un n�mero
			if (KeyPress.All(char.IsNumber))
			{
				AddNumbersOnScreen(KeyPress);
			}
			else
			{
				switch (KeyPress)
				{
					case "+": Operation = "btn_addition"; break;
					case "-": Operation = "btn_subtraction"; break;
					case "*": Operation = "btn_multiplication"; break;
					case "/": Operation = "btn_division"; break;
				}

				PerformOperation(Operation, KeyPress);
			}
        }
		#endregion 
		#region Controles de funci�n
		//Metodo para a�adir numeros en pantalla
		private void AddNumbersOnScreen(string Number)
		{
			//Comprobar si aun no se ha igualado la operaci�n
			if (EndOperation == false)
			{
				//Validar el tama�o maximo de digitos
				if (tbx_screen.Text.Length < MaxLenght)
				{
					if (tbx_screen.Text == "0")
					{
						tbx_screen.Text = "";
					}

					tbx_screen.Text += Number;
				}
				else
				{
					MessageBox.Show("No es posible introducir m�s de " + MaxLenght + " d�gitos.");
				}
			}
			else
			{
				tbx_screen.Text = Number;
				CurrentNumber = 0;
				LastNumber = 0;
				EndOperation = false;
			}
		}

		//Metodo para realizar operaciones y funciones
		private void PerformOperation(string Function, string Sign)
		{
			switch (Function)
			{
				//Botones de operadores matematicos
				case "btn_addition": case "btn_subtraction": case "btn_multiplication": case "btn_division":
					Operator = Convert.ToChar(Sign);
					CurrentNumber = Convert.ToDouble(tbx_screen.Text);
					tbx_screen.Text = "0";
					EndOperation = false;
				break;

				//Boton de mostrar resultado
				case "btn_equal":
					if (EndOperation == false)
					{
						LastNumber = Convert.ToDouble(tbx_screen.Text);
					}

					switch (Operator)
					{
						case '+': tbx_screen.Text = Convert.ToString(CurrentNumber + LastNumber); break;
						case '-': tbx_screen.Text = Convert.ToString(CurrentNumber - LastNumber); break;
						case 'x': tbx_screen.Text = Convert.ToString(CurrentNumber * LastNumber); break;
						case '�': tbx_screen.Text = Convert.ToString(CurrentNumber / LastNumber); break;
					}

					CurrentNumber = Convert.ToDouble(tbx_screen.Text);
					EndOperation = true;
				break;

				//Boton de limpiar operaci�n
				case "btn_clear":
					tbx_screen.Text = "0";
					CurrentNumber = 0;
					LastNumber = 0;
					EndOperation = false;
				break;

				//Boton de intercambiar el signo del valor actual
				case "btn_sign":
					if (tbx_screen.Text != "0")
					{
						CurrentNumber = Convert.ToDouble(tbx_screen.Text);
						CurrentNumber *= -1;
						tbx_screen.Text = Convert.ToString(CurrentNumber);
					}
				break;

				//Boton de borrar
				case "btn_delete":
					if (tbx_screen.Text.Length == 2 && tbx_screen.Text.Contains("-") || tbx_screen.Text.Length < 2)
					{
						tbx_screen.Text = "0";
					}
					else
					{
						tbx_screen.Text = tbx_screen.Text.Substring(0, tbx_screen.Text.Length - 1);
					}
				break;

				//Boton de a�adir punto decimal
				case "btn_point":
					if (!tbx_screen.Text.Contains("."))
					{
						tbx_screen.Text += ".";
					}
				break;
			}
		}
		#endregion
	}
}