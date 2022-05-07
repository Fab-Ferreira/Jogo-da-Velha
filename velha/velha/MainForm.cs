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
		
		// Variáveis
		int player1Wins, player2Wins, ties;
		bool vez = true;
		
		public void ExClick(object sender, EventArgs e)
		{
			Button[] b = {button1, button2, button3, button4, button5, button6, button7, button8, button9}; //Grupo de botões
			
			//Se for a vez do jogador 1
			if(vez == true && (sender as Button).Text == "")
			{
				(sender as Button).Text = "X"; //Botão pressionado recebe texto "X"
				(sender as Button).BackColor = Color.SeaGreen; //Botão pressionado recebe cor de fundo SeaGreen
				
				//Alterar a vez do jogador
				vez = !vez;
				rodada.Text = "Player 2";
				rodada.ForeColor = Color.Salmon;
				
				//if para especificar quando é que o player 1 vence
				if((b[0].Text == "X" && b[1].Text == "X" && b[2].Text == "X") || (b[3].Text == "X" && b[4].Text == "X" && b[5].Text == "X") || (b[6].Text == "X" && b[7].Text == "X" && b[8].Text == "X")
			 	  || (b[0].Text == "X" && b[3].Text == "X" && b[6].Text == "X") || (b[1].Text == "X" && b[4].Text == "X" && b[7].Text == "X") || (b[2].Text == "X" && b[5].Text == "X" && b[8].Text == "X")
			 	  || (b[0].Text == "X" && b[4].Text == "X" && b[8].Text == "X") || (b[2].Text == "X" && b[4].Text == "X" && b[6].Text == "X"))
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
			
			//Se for a vez do jogador 2
			else if(vez == false && (sender as Button).Text == "")
			{
				(sender as Button).Text = "O"; //Botão pressionado recebe texto "O"
				(sender as Button).BackColor = Color.Salmon; //Botão pressionado recebe cor de fundo Salmon
				
				//Alternar a vez de jogador
				vez = !vez;
				rodada.Text = "Player 1";
				rodada.ForeColor = Color.SeaGreen;
				
				//if para especificar quando é que o player 2 vence
				if((b[0].Text == "O" && b[1].Text == "O" && b[2].Text == "O") || (b[3].Text == "O" && b[4].Text == "O" && b[5].Text == "O") || (b[6].Text == "O" && b[7].Text == "O" && b[8].Text == "O")
			 	  || (b[0].Text == "O" && b[3].Text == "O" && b[6].Text == "O") || (b[1].Text == "O" && b[4].Text == "O" && b[7].Text == "O") || (b[2].Text == "O" && b[5].Text == "O" && b[8].Text == "O")
			 	  || (b[0].Text == "O" && b[4].Text == "O" && b[8].Text == "O") || (b[2].Text == "O" && b[4].Text == "O" && b[6].Text == "O"))
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
				
				//Clear
				for(int i = 0; i < 9; i++)
				{
					b[i].BackColor = Color.LightCyan;
					b[i].Text = "";
				}
			}
		}
	}
}
