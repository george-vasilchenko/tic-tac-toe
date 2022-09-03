namespace TicTacToe
{
    public partial class GameBoard : Form
    {
        private const string CirclePlayerName = "Circle";
        private const string CrossPlayerName = "Cross";
        private const int GameBoardHeight = 3;
        private const int GameBoardWidth = 3;
        private readonly PictureBox[] pictureBoxes;
        private readonly RadioButton[] radioButtons;
        private readonly int[][,] winSituations;
        private int[,] circlePlayerScoreMatrix;
        private int[,] crossPlayerScoreMatrix;
        private int turnCount = 0;

        public GameBoard()
        {
            InitializeComponent();

            crossPlayerScoreMatrix = InitializePlayerScore();
            circlePlayerScoreMatrix = InitializePlayerScore();
            winSituations = InitializeWinSituations();
            pictureBoxes = new[] {
                GameField_00, GameField_01, GameField_02,
                GameField_10, GameField_11, GameField_12,
                GameField_20, GameField_21, GameField_22 };
            SetEnabledPictureBoxes(true, pictureBoxes);

            radioButtons = new RadioButton[] {
                CrossRadioButton, CircleRadioButton };
            DisableRadioButtons(radioButtons);

            InitializeGameResult(GameResultLabel);

            SwitchCurrentPlayer();
        }

        private static void DisableRadioButtons(RadioButton[] radioButtons)
        {
            for (var i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].Enabled = false;
            }
        }

        private static int[] GetFieldIndex(PictureBox gameField)
        {
            var name = gameField.Name;
            var nameParts = name.Split("_");
            var numbersPart = nameParts[nameParts.Length - 1];
            var numberChars = numbersPart.ToCharArray();
            var rowIndex = int.Parse(numberChars[0].ToString());
            var columnIndex = int.Parse(numberChars[1].ToString());

            return new int[] { rowIndex, columnIndex };
        }

        private static void InitializeGameResult(Label gameResultLabel)
        {
            gameResultLabel.Text = string.Empty;
        }

        private static int[,] InitializePlayerScore()
        {
            return new int[GameBoardHeight, GameBoardWidth]
            {
               { 0, 0, 0 },
               { 0, 0, 0 },
               { 0, 0, 0 }
            };
        }

        private static int[][,] InitializeWinSituations()
        {
            return new int[8][,]
            {
                new int[,]
                {
                   { 1, 1, 1 },
                   { 0, 0, 0 },
                   { 0, 0, 0 }
                },
                new int[,]
                {
                   { 0, 0, 0 },
                   { 1, 1, 1 },
                   { 0, 0, 0 }
                },
                new int[,]
                {
                   { 0, 0, 0 },
                   { 0, 0, 0 },
                   { 1, 1, 1 }
                },
                new int[,]
                {
                   { 1, 0, 0 },
                   { 1, 0, 0 },
                   { 1, 0, 0 }
                },
                new int[,]
                {
                   { 0, 1, 0 },
                   { 0, 1, 0 },
                   { 0, 1, 0 }
                },
                new int[,]
                {
                   { 0, 0, 1 },
                   { 0, 0, 1 },
                   { 0, 0, 1 }
                },
                new int[,]
                {
                   { 1, 0, 0 },
                   { 0, 1, 0 },
                   { 0, 0, 1 }
                },
                new int[,]
                {
                   { 0, 0, 1 },
                   { 0, 1, 0 },
                   { 1, 0, 0 }
                }
            };
        }

        private static void SetCoverImages(PictureBox[] pictureBoxes)
        {
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                var pb = pictureBoxes[i];
                pb.BackgroundImage.Dispose();
                pb.BackgroundImage = Resources.Images.Cover;
            }
        }

        private static void SetEnabledPictureBoxes(bool isEnabled, PictureBox[] pictureBox)
        {
            for (var i = 0; i < pictureBox.Length; i++)
            {
                pictureBox[i].Enabled = isEnabled;
            }
        }

        private static void StopGame(PictureBox[] pictureBoxes)
        {
            SetEnabledPictureBoxes(false, pictureBoxes);
        }

        private void CongratulatePlayer(string playerName)
        {
            GameResultLabel.Text = $"Player {playerName} has won!";
        }

        private void EvaluateGameState()
        {
            var playerWon = false;

            for (int i = 0; i < winSituations.Length; i++)
            {
                var winSituation = winSituations[i];

                if (IsMatchingCondition(winSituation, crossPlayerScoreMatrix))
                {
                    CongratulatePlayer(CrossPlayerName);
                    StopGame(pictureBoxes);
                    playerWon = true;
                    break;
                }

                if (IsMatchingCondition(winSituation, circlePlayerScoreMatrix))
                {
                    CongratulatePlayer(CirclePlayerName);
                    StopGame(pictureBoxes);
                    playerWon = true;
                    break;
                }
            }

            if (NoTurnsLeft() && !playerWon)
            {
                ShowGameDraw();
                StopGame(pictureBoxes);
            }
        }

        private bool GameFieldIsAlreadyUsed(int[] fieldIndex)
        {
            var row = fieldIndex[0];
            var column = fieldIndex[1];

            return crossPlayerScoreMatrix[row, column] == 1 || circlePlayerScoreMatrix[row, column] == 1;
        }

        private string GetCurrentPlayer()
        {
            if (CrossRadioButton.Checked)
            {
                return CrossPlayerName;
            }
            else if (CircleRadioButton.Checked)
            {
                return CirclePlayerName;
            }
            else
            {
                throw new InvalidOperationException("Two radio buttons cant be checked at the same time");
            }
        }

        private void IncrementTurnCount()
        {
            turnCount++;
        }

        private bool IsMatchingCondition(int[,] winSituation, int[,] playerScores)
        {
            for (int row = 0; row < GameBoardHeight; row++)
            {
                for (int column = 0; column < GameBoardHeight; column++)
                {
                    var winValue = winSituation[row, column];
                    if (winValue == 0)
                    {
                        continue;
                    }

                    var playerValue = playerScores[row, column];
                    if (winValue != playerValue)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool NoTurnsLeft()
        {
            return turnCount == GameBoardHeight * GameBoardWidth;
        }

        private void OnPictureBoxClicked(object? sender)
        {
            var pictureBox = (PictureBox)sender!;
            var fieldIndex = GetFieldIndex(pictureBox);
            var currentPlayer = GetCurrentPlayer();

            if (GameFieldIsAlreadyUsed(fieldIndex))
            {
                return;
            }

            ProcessPlayerTurn(pictureBox, fieldIndex, currentPlayer);
            IncrementTurnCount();
            EvaluateGameState();
            SwitchCurrentPlayer();
        }

        private void ProcessPlayerTurn(PictureBox pictureBox, int[] fieldIndex, string currentPlayer)
        {
            pictureBox.BackgroundImage.Dispose();
            if (currentPlayer == CrossPlayerName)
            {
                pictureBox.BackgroundImage = Resources.Images.Cross;
                UpdateCrossPlayerScore(fieldIndex);
            }
            else
            {
                pictureBox.BackgroundImage = Resources.Images.Circle;
                UpdateCirclePlayerScore(fieldIndex);
            }
        }

        private void RestartGame(PictureBox[] pictureBoxes)
        {
            crossPlayerScoreMatrix = InitializePlayerScore();
            circlePlayerScoreMatrix = InitializePlayerScore();
            turnCount = 0;

            SetCoverImages(pictureBoxes);
            SetEnabledPictureBoxes(true, pictureBoxes);
            InitializeGameResult(GameResultLabel);
        }

        private void ShowGameDraw()
        {
            GameResultLabel.Text = $"Match draw! Try again!";
        }

        private void SwitchCurrentPlayer()
        {
            if (CrossRadioButton.Checked)
            {
                CrossRadioButton.Checked = false;
                CircleRadioButton.Checked = true;
            }
            else if (CircleRadioButton.Checked)
            {
                CrossRadioButton.Checked = true;
                CircleRadioButton.Checked = false;
            }
            else
            {
                throw new InvalidOperationException("Two radio buttons cant be checked at the same time");
            }
        }

        private void UpdateCirclePlayerScore(int[] fieldIndex)
        {
            var row = fieldIndex[0];
            var column = fieldIndex[1];
            circlePlayerScoreMatrix[row, column] = 1;
        }

        private void UpdateCrossPlayerScore(int[] fieldIndex)
        {
            var row = fieldIndex[0];
            var column = fieldIndex[1];
            crossPlayerScoreMatrix[row, column] = 1;
        }

        #region Event Handlers

        private void GameField_11_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void GameField_12_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void GameField_13_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void GameField_21_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void GameField_22_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void GameField_23_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void GameField_31_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void GameField_32_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void GameField_33_Click(object sender, EventArgs e)
        {
            OnPictureBoxClicked(sender);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            RestartGame(pictureBoxes);
        }

        #endregion Event Handlers
    }
}
