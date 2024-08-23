namespace TextGame
{
    public enum BATTLERESULT
    {
        NONE,
        WIN,
        DRAW,
        LOSE,
    }

    public enum CARD
    {
        NONE,
        SCISSORS,
        ROCK,
        PAPER,
    }

    public class GCWCard
    {
        public CARD CardType;

        public static BATTLERESULT Battle(GCWCard own, GCWCard enemy)
        {
            BATTLERESULT result = BATTLERESULT.NONE;

            if (own.CardType == CARD.SCISSORS)
            {
                switch (enemy.CardType)
                {
                    case CARD.SCISSORS:
                        result = BATTLERESULT.DRAW;
                        break;
                    case CARD.ROCK:
                        result = BATTLERESULT.LOSE;
                        break;
                    case CARD.PAPER:
                        result = BATTLERESULT.WIN;
                        break;
                }
            }
            else if (own.CardType == CARD.ROCK)
            {
                switch (enemy.CardType)
                {
                    case CARD.SCISSORS:
                        result = BATTLERESULT.WIN;
                        break;
                    case CARD.ROCK:
                        result = BATTLERESULT.DRAW;
                        break;
                    case CARD.PAPER:
                        result = BATTLERESULT.LOSE;
                        break;
                }
            }
            else if (own.CardType == CARD.PAPER)
            {
                switch (enemy.CardType)
                {
                    case CARD.SCISSORS:
                        result = BATTLERESULT.LOSE;
                        break;
                    case CARD.ROCK:
                        result = BATTLERESULT.WIN;
                        break;
                    case CARD.PAPER:
                        result = BATTLERESULT.DRAW;
                        break;
                }

            }

            return result;
        }


        private void GenerateRandomCard()
        {
            Random random = new Random();
            int result = random.Next(0, 10);

            if (result < 3)
            {
                CardType = CARD.SCISSORS;
            }
            else if (result < 6)
            {
                CardType = CARD.ROCK;
            }
            else
            {
                CardType = CARD.PAPER;
            }
        }

        public GCWCard()
        {
            GenerateRandomCard();
        }

    }
}
