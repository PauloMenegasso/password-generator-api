namespace password_generator_api.Services;

public interface IGeneratePassword
{
    string GeneratePassword(int passwordCharacteres);
}

public class GeneratePassword : IGeneratePassword
{
    string IGeneratePassword.GeneratePassword(int passwordCharacteres)
    {
        if (passwordCharacteres > 100)
        {
            return "Acho que você não vai lembrar de uma senha tão grande...";
        }
        var random = new Random();
        var passwordCharactersList = new List<Char>{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I',
            'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R',
            's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z', '!', '@',
            '#', '$', '%', '&', '*', '(', ')', '[', ']', '{', '}', '+', '-', '/', '|', '<', '>', '='};
        var password = "";

        for (var i = 0; i < passwordCharacteres; i++)
        {
            password += passwordCharactersList[random.Next(0, passwordCharactersList.Count())];
        }
        return password;
    }
}
