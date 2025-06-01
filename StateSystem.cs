using MyFirstWinform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinform
{
    interface sectionGuessState
    {
        private static Image image = Properties.Resources.Incorrect_Guess;
        string returnCurrentState();
        Image returnCurrentImage();
    }

    class NoState : sectionGuessState
    {
        private static Image image = Properties.Resources.Incorrect_Guess;

        public string returnCurrentState()
        {
            return "No Guess Here";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class IncorrectState : sectionGuessState
    {
        private static Image image = Properties.Resources.Incorrect_Guess;

        public string returnCurrentState()
        {
            return "INCORRECT";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class CloseState : sectionGuessState
    {
        private static Image image = Properties.Resources.Close_Guess;

        public string returnCurrentState()
        {
            return "CLOSE";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class CorrectState : sectionGuessState
    {
        public static Image image = Properties.Resources.Correct_Guess;

        public string returnCurrentState()
        {
            return "CORRECT";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class WinState : sectionGuessState
    {
        private static Image image = Properties.Resources.Player_Wins;

        public string returnCurrentState()
        {
            return "YOU WIN";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class OutOfGuessesState : sectionGuessState
    {
        private static Image image = Properties.Resources.Player_Loses;

        public string returnCurrentState()
        {
            return "YOU LOSE";
        }
        public Image returnCurrentImage()
        {
            return image;
        }
    }

    class sectionGuessContext
    {
        public sectionGuessState state = new NoState();

        public void setState(sectionGuessState state)
        {
            this.state = state;
        }

        public string request()
        {
            return state.returnCurrentState();
        }

        public Image getImage()
        {
            return state.returnCurrentImage();
        }
    }



    class StateKeeperImplementation
    {
        sectionGuessContext[] lastGuessesState1 = new sectionGuessContext[2];
        sectionGuessContext[] lastGuessesState2 = new sectionGuessContext[2];
        sectionGuessContext[] lastGuessesState3 = new sectionGuessContext[2];

        NoState noState = new NoState();
        IncorrectState incorrectState = new IncorrectState();
        CloseState closeState = new CloseState();
        CorrectState correctState = new CorrectState();
        WinState winState = new WinState();
        OutOfGuessesState outOfGuessesState = new OutOfGuessesState();

        public void SetLastGuessesState(int section, bool correct, bool sectionOver)
        {
            if (correct)
            {
                if (section == 1)
                {
                    lastGuessesState1[1].setState(lastGuessesState1[0].state);
                    lastGuessesState1[0].setState(getCorrectOptions(sectionOver));
                }
                else if (section == 2)
                {
                    lastGuessesState2[1].setState(lastGuessesState2[0].state);
                    lastGuessesState2[0].setState(getCorrectOptions(sectionOver));
                }
                else if (section == 3)
                {
                    lastGuessesState3[1].setState(lastGuessesState3[0].state);
                    lastGuessesState3[0].setState(getCorrectOptions(sectionOver));
                }
            }
            else
            {
                if (section == 1)
                {
                    lastGuessesState1[1].setState(lastGuessesState1[0].state);
                    lastGuessesState1[0].setState(getIncorrectOptions(sectionOver));
                }
                else if (section == 2)
                {
                    lastGuessesState2[1].setState(lastGuessesState2[0].state);
                    lastGuessesState2[0].setState(getIncorrectOptions(sectionOver));
                }
                else if (section == 3)
                {
                    lastGuessesState3[1].setState(lastGuessesState3[0].state);
                    lastGuessesState3[0].setState(getIncorrectOptions(sectionOver));
                }
            }
        }

        public sectionGuessState getIncorrectOptions(bool sectionOver)
        {
            if (sectionOver)
            {
                return outOfGuessesState;
            }
            else
            {
                return incorrectState;
            }
        }

        public sectionGuessState getCorrectOptions(bool sectionOver)
        {
            if (sectionOver)
            {
                return winState;
            }
            else
            {
                return correctState;
            }
        }

    }
}
