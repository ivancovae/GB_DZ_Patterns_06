namespace Patterns_06
{
    /// <summary>
    /// Абстрактный класс одобрителя
    /// </summary>
    abstract class AbstractHandler : Handler
    {
        private Handler nextHandler;

        /// <summary>
        /// Задать слудующую инстранцию
        /// </summary>
        /// <param name="handler">следйющий одобритель</param>
        /// <returns>успешно помеченный одобритель</returns>
        public Handler setNext(Handler handler)
        {
            nextHandler = handler;
            return handler;
        }

        /// <summary>
        /// Запрос количества денег
        /// </summary>
        /// <param name="price">сколько запрашиваем</param>
        /// <returns>подтверждение или отказ</returns>
        public virtual string GetMoney(int price)
        {
            if (nextHandler != null)
            {
                return nextHandler.GetMoney(price);
            }
            else
            {
                return "It takes too many money";
            }
        }
    }
}
