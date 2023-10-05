/* 
 * TicTacToeForm.cs
 * Assignment 1
 * Revision History
 *      Josh Lanesmith 2023-09-14: Created
 *      Josh Lanesmith 2023-09-20: Add player icon images with speech bubbles
 *      Josh Lanesmith 2023-09-21: Add starting sequence with player icons
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLanesmithAssignment1
{
	/// <summary>
	/// A class for a simple game of Tic Tac Toe.
	/// </summary>
	public partial class TicTacToeForm : Form
	{
		//Define enum used to track the board square assignments and whose turn it is
		enum Player
		{
			empty, x, o
		}

		// Declaring class variables
		Player turn;
		Player[,] board = new Player[3, 3];
		int turnCounter = 1;
		const int TOGGLE_TURN_ANIMATION_DELAY = 200;

		// Delclaring image paths
		static readonly Image playerIconX = Properties.Resources.player_x_icon;
		static readonly Image playerIconReadyX = Properties.Resources.player_x_are_you_ready;
		static readonly Image playerIconTurnX = Properties.Resources.player_x_my_turn;
		static readonly Image playerIconWinX = Properties.Resources.player_x_i_win;
		static readonly Image boardIconX = Properties.Resources.x_image;

		static readonly Image playerIconO = Properties.Resources.player_o_icon;
		static readonly Image playerIconPlayO = Properties.Resources.player_o_lets_play;
		static readonly Image playerIconTurnO = Properties.Resources.player_o_my_turn;
		static readonly Image playerIconWinO = Properties.Resources.player_o_i_win;
		static readonly Image boardIconO = Properties.Resources.o_image;

		// Declare dictionary to store the board coordinates of each picture box
		// Dictionary initialized in form constructor
		Dictionary<PictureBox, int[]> pictureBoxCoordinates;

		// Define starting sequence for when the game first loads
		#region Starting Sequence

		const int STARTING_SEQUENCE_STEPS_LENGTH = 3;
		const int STARTING_SEQUENCE_INTERVAL = 1500;
		int startingSequenceStepCounter = 0;

		readonly Image[] playerStartingImageSequenceX = new Image[STARTING_SEQUENCE_STEPS_LENGTH]{
			playerIconReadyX,
			playerIconX,
			playerIconTurnX
		};

		readonly Image[] playerStartingImageSequenceO = new Image[STARTING_SEQUENCE_STEPS_LENGTH]{
			playerIconO,
			playerIconPlayO,
			playerIconO
		};

		System.Windows.Forms.Timer startingSequenceTimer = new System.Windows.Forms.Timer();

		/// <summary>
		/// Event handler to run on a timer and display the sequence of starting images.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RunStartingSequence(object sender, EventArgs e)
		{
			// Display the player icons in the predefined sequence order
			picPlayerX.Image = playerStartingImageSequenceX[startingSequenceStepCounter];
			picPlayerO.Image = playerStartingImageSequenceO[startingSequenceStepCounter];

			// Increment the starting sequence step counter
			startingSequenceStepCounter++;

			// Stop the timer from ticking when the step counter reaches the starting sequence length
			if (startingSequenceStepCounter >= STARTING_SEQUENCE_STEPS_LENGTH)
			{
				startingSequenceTimer.Stop();

				// Re-enable the Form UI after the startingSequenceTimer has been stopped 
				this.Enabled = true;
			}
		}

		#endregion

		#region Class Methods

		/// <summary>
		/// Assign the selected board square to the current player if the square is empty.
		/// </summary>
		/// <param name="square">PictureBox control associated with the board.</param>
		/// <returns>return -1 if the square is already occupied, return 1 if the square was assigned successfully</returns>
		private int AssignSquare(PictureBox square)
		{
			int row = pictureBoxCoordinates[square][0];
			int col = pictureBoxCoordinates[square][1];

			// Check if the selected board location is already occupied
			if (board[row, col] != Player.empty)
			{
				return -1;
			}

			// Set the square image and board location based on whose turn it is
			if (turn == Player.x)
			{
				square.Image = boardIconX;
			}
			else
			{
				square.Image = boardIconO;
			}
			board[row, col] = turn;

			return 1;
		}

		/// <summary>
		/// Check if the current player won after taking their turn or if the all squares are full and it ends in a tie.
		/// </summary>
		/// <returns>return -1 if game continues, return 0 if game ends in a tie, return 1 if current player wins.</returns>
		private int CheckWin()
		{
			// Return -1 to continue game if less than 5 turns have been taken
			if (turnCounter < 5)
			{
				return -1;
			}

			// Return 1 to indicate a win if any of the win conditions return true
			if (board[0, 0] == turn)
			{
				if (board[0, 1] == turn && board[0, 2] == turn)
				{
					return 1;
				}
				else if (board[1, 1] == turn && board[2, 2] == turn)
				{
					return 1;
				}
				else if (board[1, 0] == turn && board[2, 0] == turn)
				{
					return 1;
				}
			}
			if (board[1, 1] == turn)
			{
				if (board[1, 0] == turn && board[1, 2] == turn)
				{
					return 1;
				}
				else if (board[0, 2] == turn && board[2, 0] == turn)
				{
					return 1;
				}
				else if (board[0, 1] == turn && board[2, 1] == turn)
				{
					return 1;
				}
			}
			if (board[2, 2] == turn)
			{
				if (board[2, 0] == turn && board[2, 1] == turn)
				{
					return 1;
				}
				else if (board[0, 2] == turn && board[1, 2] == turn)
				{
					return 1;
				}
			}

			// Return 0 to indicate a tie if 9 turns have been completed without a win
			if (turnCounter == 9)
			{
				return 0;
			}

			return -1;
		}

		/// <summary>
		/// Increases the turn counter and updates who's turn it is 'x' or 'o'.
		/// </summary>
		private void ToggleTurn()
		{
			if (turn == Player.x)
			{
				turn = Player.o;
				picPlayerX.Image = playerIconX;
				Thread.Sleep(TOGGLE_TURN_ANIMATION_DELAY);
				picPlayerO.Image = playerIconTurnO;
			}
			else
			{
				turn = Player.x;
				picPlayerO.Image = playerIconO;
				Thread.Sleep(TOGGLE_TURN_ANIMATION_DELAY);
				picPlayerX.Image = playerIconTurnX;
			}

			turnCounter++;
		}


		/// <summary>
		/// Reset the board for a new game. Set the turn to Player.x, reset the turn counter to 1, 
		/// and reset all board squares to empty.
		/// </summary>
		private void ResetBoard()
		{
			// Set first turn to always be player 'X'
			turn = Player.x;
			turnCounter = 1;

			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					board[i, j] = Player.empty;
				}
			}

			foreach (PictureBox square in this.Controls.OfType<PictureBox>())
			{
				square.Image = null;
			}

			// Set player icon images to indicate player X's turn
			picPlayerX.Image = playerIconTurnX;
			picPlayerO.Image = playerIconO;
		}

		#endregion

		/// <summary>
		/// Constructor of the Form.
		/// </summary>
		public TicTacToeForm()
		{
			InitializeComponent();

			// Define coordinates of each picture box square of the board
			pictureBoxCoordinates = new Dictionary<PictureBox, int[]>
			{
				{ picTopLeft, new int[]{ 0, 0 } },
				{ picTopMiddle, new int[]{ 0, 1 } },
				{ picTopRight, new int[]{ 0, 2 } },
				{ picMiddleLeft, new int[]{ 1, 0 } },
				{ picMiddleMiddle, new int[]{ 1, 1 } },
				{ picMiddleRight, new int[]{ 1, 2 } },
				{ picBottomLeft, new int[]{ 2, 0 } },
				{ picBottomMiddle, new int[]{ 2, 1 } },
				{ picBottomRight, new int[]{ 2, 2 } },
			};

		}

		/// <summary>
		/// This method executes when the Form loads and sets the first player as 'x'.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TicTacToeForm_Load(object sender, EventArgs e)
		{
			// Disable the Form UI to block user input while the form loads and the startingSequenceTimer runs
			this.Enabled = false;

			turn = Player.x;

			picPlayerX.Image = playerIconX;
			picPlayerO.Image = playerIconO;

			startingSequenceTimer.Interval = STARTING_SEQUENCE_INTERVAL;
			startingSequenceTimer.Tick += new EventHandler(RunStartingSequence);
			startingSequenceTimer.Start();
		}

		/// <summary>
		/// This method executes when any of the board squares are clicked and assigns the square to the current player.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BoardSquare_Click(object sender, EventArgs e)
		{
			int turnCompleted = AssignSquare((PictureBox)sender);

			// If AssignSquare returns -1 to turn completed then return out of current event without toggling turn
			if (turnCompleted == -1)
			{
				return;
			}

			int turnStatus = CheckWin();

			// Evaluate the result of the CheckWin() method and display winner or tie message if applicable.
			if (turnStatus == 1)
			{
				switch (turn)
				{
					case Player.x:
						Thread.Sleep(TOGGLE_TURN_ANIMATION_DELAY);
						picPlayerX.Image = playerIconWinX;
						picPlayerO.Image = playerIconO;
						MessageBox.Show("X wins!", "Game End", MessageBoxButtons.OK);
						break;
					case Player.o:
						Thread.Sleep(TOGGLE_TURN_ANIMATION_DELAY);
						picPlayerX.Image = playerIconX;
						picPlayerO.Image = playerIconWinO;
						MessageBox.Show("O wins!", "Game End", MessageBoxButtons.OK);
						break;
					default:
						break;
				}
				ResetBoard();
			}
			else if (turnStatus == 0)
			{
				picPlayerX.Image = playerIconX;
				picPlayerO.Image = playerIconO;
				MessageBox.Show("Tie", "Game End", MessageBoxButtons.OK);
				ResetBoard();
			}
			else
			{
				ToggleTurn();
			}
		}
	}
}
