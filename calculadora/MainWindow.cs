using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	string operador;
	int a = 0;
	bool validar = false;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void btnNumerador_Click (object sender, EventArgs e)
	{
		Button bt = (Button)sender;
		txt_valor.Text = txt_valor.Text + bt.Label;

	}

	protected void OnBtnLimparClicked (object sender, EventArgs e)
	{
		txt_valor.Text = "";
		label2.Text = "";
		a = 0;
		validar = false;
	}

	protected void OnBtnAdicaoClicked (object sender, EventArgs e)
	{
		if (validar == true) 
		{
			a = a + Convert.ToInt32 (txt_valor.Text);
			label2.Text = Convert.ToString (a) + "+";
			txt_valor.Text = "";
			operador = "+";
		}
		else
		{
			label2.Text = txt_valor.Text + btn_adicao.Label;
			a = Convert.ToInt32 (txt_valor.Text);
			txt_valor.Text = "";
			operador = "+";
			validar = true;
	    }
    }

	protected void OnBtnSubtracaoClicked (object sender, EventArgs e)
	{
		if (validar == true) 
		{
			a = a - Convert.ToInt32 (txt_valor.Text);
			label2.Text = Convert.ToString (a) + "-";
			txt_valor.Text = "";
			operador = "-";
		}
		else
		{
			label2.Text = txt_valor.Text + btn_subtracao.Label;
			a = Convert.ToInt32 (txt_valor.Text);
			txt_valor.Text = "";
			operador = "-";
			validar = true;
		}
	}

	protected void OnTbnMultiplicacaoClicked (object sender, EventArgs e)
	{
		if (validar == true) 
		{
			a = a * Convert.ToInt32 (txt_valor.Text);
			label2.Text = Convert.ToString (a) + "*";
			txt_valor.Text = "";
			operador = "*";
		}
		else
		{
			label2.Text = txt_valor.Text + tbn_multiplicacao.Label;
			a = Convert.ToInt32 (txt_valor.Text);
			txt_valor.Text = "";
			operador = "*";
			validar = true;
		}
	}

	protected void OnBtnDivisaoClicked (object sender, EventArgs e)
	{
		if (validar == true) 
		{
			a = a / Convert.ToInt32 (txt_valor.Text);
			label2.Text = Convert.ToString (a) + "/";
			txt_valor.Text = "";
			operador = "/";
		}
		else
		{
			label2.Text = txt_valor.Text + btn_divisao.Label;
			a = Convert.ToInt32 (txt_valor.Text);
			txt_valor.Text = "";
			operador = "/";
			validar = true;
		}
	}

	protected void OnBtnIgualClicked (object sender, EventArgs e)
	{
		switch (operador) 
		{
		case "+":
			label2.Text = label2.Text + txt_valor.Text + "="; 
			txt_valor.Text = Convert.ToString(a + Convert.ToInt32(txt_valor.Text));
			break;
		case "-":
			label2.Text = label2.Text + txt_valor.Text + "=";
			txt_valor.Text = Convert.ToString(a - Convert.ToInt32(txt_valor.Text));
			break;
		case "*":
			label2.Text = label2.Text + txt_valor.Text + "=";
			txt_valor.Text = Convert.ToString(a * Convert.ToInt32(txt_valor.Text));
			break;
		case "/":
			label2.Text = label2.Text + txt_valor.Text + "=";
			txt_valor.Text = Convert.ToString(a / Convert.ToInt32(txt_valor.Text));
			break;	

		}

	}
}