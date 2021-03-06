namespace MIMER.RFC2045
{
    public class BasicEndOfMessageStrategy : IEndCriteriaStrategy
    {
        #region IEndCriteriaStrategy Members

        public bool IsEndReached(char[] data, int size)
        {
            if (size >= 4)
            {
                int fifth = data[size - 4];
                int fourth = data[size - 3];
                int third = data[size - 2];
                int second = data[size - 1];
                int first = data[size];

                //'CTRL.CTRL' indicates end of message
                if (fifth == 13 && fourth == 10 && third == 46 &&
                    second == 13 && first == 10)
                {
                    return true;
                }
            }

            if (size >= 2)
            {
                int third = data[0];
                int second = data[1];
                int first = data[2];

                //'.CTRL' indicates end of message
                if (third == 46 && second == 13 && first == 10)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}