using MyFirstWinform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

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

        public string returnCurrentState() { return "No Guess Here"; }
        public Image returnCurrentImage() { return image; }
    }

    class IncorrectState : sectionGuessState
    {
        private static Image image = Properties.Resources.Incorrect_Guess;

        public string returnCurrentState() { return "INCORRECT"; }
        public Image returnCurrentImage() { return image; }
    }

    class CloseState : sectionGuessState
    {
        private static Image image = Properties.Resources.Close_Guess;

        public string returnCurrentState() { return "CLOSE"; }
        public Image returnCurrentImage() { return image; }
    }

    class CorrectState : sectionGuessState
    {
        public static Image image = Properties.Resources.Correct_Guess;

        public string returnCurrentState() { return "CORRECT"; }
        public Image returnCurrentImage() { return image; }
    }

    class WinState : sectionGuessState
    {
        private static Image image = Properties.Resources.Player_Wins;

        public string returnCurrentState() { return "YOU WIN"; }
        public Image returnCurrentImage() { return image; }
    }

    class OutOfGuessesState : sectionGuessState
    {
        private static Image image = Properties.Resources.Player_Loses;

        public string returnCurrentState() { return "YOU LOSE"; }
        public Image returnCurrentImage() { return image; }
    }

    class sectionGuessContext
    {
        public sectionGuessState state = new NoState();

        public void setState(sectionGuessState state) { this.state = state; }

        public string request() { return state.returnCurrentState(); }

        public Image getImage() { return state.returnCurrentImage(); }
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

        public StateKeeperImplementation()
        {
            lastGuessesState1[0] = new sectionGuessContext();
            lastGuessesState1[1] = new sectionGuessContext();
            lastGuessesState2[0] = new sectionGuessContext();
            lastGuessesState2[1] = new sectionGuessContext();
            lastGuessesState3[0] = new sectionGuessContext();
            lastGuessesState3[1] = new sectionGuessContext();
            ResetKeeper();
        }

        public void ResetKeeper()
        {
            lastGuessesState1[0].setState(noState);
            lastGuessesState1[1].setState(noState);
            lastGuessesState2[0].setState(noState);
            lastGuessesState2[1].setState(noState);
            lastGuessesState3[0].setState(noState);
            lastGuessesState3[1].setState(noState);
        }

        public bool check_win()
        {
            if (lastGuessesState1[0].state is CorrectState && lastGuessesState2[0].state is CorrectState && lastGuessesState3[0].state is CorrectState)
            {
                SetLastGuessesState(true, true);
                return true;
            }
            return false;
        }

        public string GetState(int section, bool first = true)
        {
            if (first)
            {
                if (section == 1) return lastGuessesState1[0].request();
                else if (section == 2) return lastGuessesState2[0].request();
                else if (section == 3) return lastGuessesState3[0].request();
                else return noState.returnCurrentState();
            }
            else
            {
                if (section == 1) return lastGuessesState1[1].request();
                else if (section == 2) return lastGuessesState2[1].request();
                else if (section == 3) return lastGuessesState3[1].request();
                else return noState.returnCurrentState();
            }
        }

        public Image GetImage(int section)
        {
            if (section == 1) return lastGuessesState1[0].getImage();
            else if (section == 2) return lastGuessesState2[0].getImage();
            else if (section == 3) return lastGuessesState3[0].getImage();
            else return noState.returnCurrentImage();
        }

        // passing anything but 1 2 or 3 will do it to all sections
        public void SetLastGuessesState(bool correct, bool sectionOver = false, int section = 0, bool close = false)
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
                else
                {
                    lastGuessesState1[1].setState(lastGuessesState1[0].state);
                    lastGuessesState1[0].setState(getCorrectOptions(sectionOver));
                    lastGuessesState2[1].setState(lastGuessesState1[0].state);
                    lastGuessesState2[0].setState(getCorrectOptions(sectionOver));
                    lastGuessesState3[1].setState(lastGuessesState1[0].state);
                    lastGuessesState3[0].setState(getCorrectOptions(sectionOver));
                }
            }
            else
            {
                if (section == 1)
                {
                    lastGuessesState1[1].setState(lastGuessesState1[0].state);
                    lastGuessesState1[0].setState(getIncorrectOptions(sectionOver, close));
                }
                else if (section == 2)
                {
                    lastGuessesState2[1].setState(lastGuessesState2[0].state);
                    lastGuessesState2[0].setState(getIncorrectOptions(sectionOver, close));
                }
                else if (section == 3)
                {
                    lastGuessesState3[1].setState(lastGuessesState3[0].state);
                    lastGuessesState3[0].setState(getIncorrectOptions(sectionOver, close));
                }
                else
                {
                    lastGuessesState1[1].setState(lastGuessesState1[0].state);
                    lastGuessesState1[0].setState(getIncorrectOptions(sectionOver, close));
                    lastGuessesState2[1].setState(lastGuessesState1[0].state);
                    lastGuessesState2[0].setState(getIncorrectOptions(sectionOver, close));
                    lastGuessesState3[1].setState(lastGuessesState1[0].state);
                    lastGuessesState3[0].setState(getIncorrectOptions(sectionOver, close));
                }
            }
        }

        public sectionGuessState getIncorrectOptions(bool sectionOver, bool close = false)
        {
            if (sectionOver) return outOfGuessesState;
            else if (close) return closeState;
            else return incorrectState;
        }

        public sectionGuessState getCorrectOptions(bool sectionOver)
        {
            if (sectionOver) return winState;
            else return correctState;
        }

    }
}
