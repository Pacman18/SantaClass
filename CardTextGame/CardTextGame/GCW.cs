using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public enum BATTLERESULT
    {
        DRAW,
        WIN,
        LOSE,
    }

    public enum GAMEGCW
    {
        SCISSORS,
        ROCK,
        PAPER,

    }

    public class GCW
    {
        // 
        static public BATTLERESULT GameResult(Player left, Player right)
        {
            BATTLERESULT isLeftwin = BATTLERESULT.DRAW;

            // 가위
            if(left.gameGCW.versusGCW == GAMEGCW.SCISSORS)
            {
                switch(right.gameGCW.versusGCW)
                {
                    case GAMEGCW.SCISSORS:
                        isLeftwin = BATTLERESULT.DRAW;
                        break;
                    case GAMEGCW.ROCK:
                        isLeftwin = BATTLERESULT.LOSE;
                        break;
                    case GAMEGCW.PAPER:
                        isLeftwin = BATTLERESULT.WIN;
                        break;

                }

                return isLeftwin;
            }

            // 바위
            if (left.gameGCW.versusGCW == GAMEGCW.ROCK)
            {
                switch (right.gameGCW.versusGCW)
                {
                    case GAMEGCW.SCISSORS:
                        isLeftwin = BATTLERESULT.WIN;
                        break;
                    case GAMEGCW.ROCK:
                        isLeftwin = BATTLERESULT.DRAW;
                        break;
                    case GAMEGCW.PAPER:
                        isLeftwin = BATTLERESULT.LOSE;
                        break;

                }

                return isLeftwin;
            }

            // 보
            if (left.gameGCW.versusGCW == GAMEGCW.PAPER)
            {
                switch (right.gameGCW.versusGCW)
                {
                    case GAMEGCW.SCISSORS:
                        isLeftwin = BATTLERESULT.LOSE;
                        break;
                    case GAMEGCW.ROCK:
                        isLeftwin = BATTLERESULT.WIN;
                        break;
                    case GAMEGCW.PAPER:
                        isLeftwin = BATTLERESULT.DRAW;
                        break;

                }

                return isLeftwin;
            }

            return isLeftwin;
        }


        public GAMEGCW versusGCW;

        // 내가 키입력할때 호출
        public void SetForceGCW(int keycode)
        {
            switch (keycode)
            {
                case 0:
                    versusGCW = GAMEGCW.SCISSORS;
                    break;
                case 1:
                    versusGCW = GAMEGCW.ROCK;
                    break;
                case 2:
                    versusGCW = GAMEGCW.PAPER;
                    break;
            }
        }

        // AI용 호출
        public void SetRandGCW()
        {
            Random random = new Random();
            int result = random.Next(0,3);

            switch(result)
            {
                case 0:
                    versusGCW = GAMEGCW.SCISSORS;
                    break;
                case 1:
                    versusGCW = GAMEGCW.ROCK;
                    break;
                case 2:
                    versusGCW = GAMEGCW.PAPER;
                    break;
            }

        }

    }
}
