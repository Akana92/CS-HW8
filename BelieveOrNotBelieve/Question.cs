using System;

namespace BelieveOrNotBelieve
{
    //Класс для вопроса
    [Serializable]
    public class Question
    {
        string text;       // Текст вопроса
        bool trueFalse;    // Правда или нет

        public string Text { get { return text; } set { if (value.GetType() == typeof(string)) text = value; } }
        public bool TrueFalse { get { return trueFalse; } set { if (value.GetType() == typeof(bool)) trueFalse = value; } }

        
        //Для сериализации приводится пустой конструктор
        public Question()
        {
        }

        //Метод записи вопроса
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }

}
