namespace Patterns_06
{
    /// <summary>
    /// Интерфейс одобрителя
    /// </summary>
    interface Handler
    {
        /// <summary>
        /// задание следующего одобрителя
        /// </summary>
        /// <param name="handler">следующий одобритель</param>
        /// <returns>успешно помеченный одобритель</returns>
        Handler setNext(Handler handler);

        /// <summary>
        /// Метод запроса определенного количества денег
        /// </summary>
        /// <param name="price">сумма запроса</param>
        /// <returns>подтверждение или отказ выделения финансирования</returns>
        string GetMoney(int price);
    }
}
