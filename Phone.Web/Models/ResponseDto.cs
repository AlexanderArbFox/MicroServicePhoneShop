namespace Phone.Web.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true; //успешный запрос или нет

        public object Result { get; set; } // неопределенный тип результата

        public string DisplayMessage { get; set; } // возврат сообщения 
        public List<string> ErrorMessages { get; set; } //список ошибок
    }
}
