/*
 * Criado por SharpDevelop.
 * Usuário: Fab
 * Data: 05/04/2022
 * Hora: 17:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace velha
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		int player1Wins, player2Wins, ties;
		bool vez = true;
		
		public void ExClick(object sender, EventArgs e)
		{
			Button[] b = {button1, button2, button3, button4, button5, button6, button7, button8, button9};
			//Random rdn = new Random();
			//int num = Convert.ToInt32(rdn.Next(0, 8));
			
			if(vez == true && (sender as Button).Text == "")
			{
				(sender as Button).Text = "X";
				(sender as Button).BackColor = Color.SeaGreen;
				
				//Alterar a vez do jogador
				vez = !vez;
				rodada.Text = "Player 2";
				rodada.ForeColor = Color.Salmon;
				
				//if imenso para especificar como o player pode vencer
				if((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
			 	  || (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
			 	  || (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
				{
					MessageBox.Show("Jogador 1 venceu!");
				
					//Quantidade de Wins do Player
					player1Wins += 1;
					winsP.Text = player1Wins.ToString();
				
					//Clear
					for(int i = 0; i < 9; i++)
					{
						b[i].BackColor = Color.LightCyan;
						b[i].Text = "";
					}
				}
			}
			
			else if(vez == false && (sender as Button).Text == "")
			{
				(sender as Button).Text = "O";
				(sender as Button).BackColor = Color.Salmon;;
				
				//Alternar a vez de jogador
				vez = !vez;
				rodada.Text = "Player 1";
				rodada.ForeColor = Color.SeaGreen;
				
				if((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
					|| (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
					|| (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
				{
					MessageBox.Show("Jogador 2 venceu!");
				
					//Quantidade de Wins do Computador
					player2Wins += 1;
					winsB.Text = player2Wins.ToString();
					
					//Clear
					for(int i = 0; i < 9; i++)
					{
						b[i].BackColor = Color.LightCyan;
						b[i].Text = "";
					}
				}
			}
			//Possível empate
			if(b[0].Text != "" && b[1].Text != "" && b[2].Text != "" && b[3].Text != "" && b[4].Text != "" && b[5].Text != "" && b[6].Text != "" && b[7].Text != "" && b[8].Text != "")
			{
				MessageBox.Show("Empate!");
				ties += 1;
				empates.Text = ties.ToString();
							
				for(int i = 0; i < 9; i++)
				{
					b[i].BackColor = Color.LightCyan;
					b[i].Text = "";
				}
			}
		}
	}
}
