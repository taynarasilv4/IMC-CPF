using System.Runtime.Serialization;
using System.Windows.Forms;
public static class Validacoes
{
    public static bool ValidaCPF(string cpf)
    {
        cpf = cpf.Replace(".", "");//Remove os pontos do Cpf
        cpf = cpf.Replace("-", "");//Remove o traço do Cpf

        if (cpf.Length == 11)//Verifica se o Cpf tem 11 dígitos
        {

            int[] multiplicador = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };//Array multiplicador para cálculo do segundo dígito verificador
            int soma1 = 0;

            for (int i = 0; i < multiplicador.Length; i++)
            {
                soma1 += multiplicador[i] * (cpf[i] - '0');//multiplica cada dígito do Cpf pelo seu respectivo multiplicador e soma os resultados
            }
           
            int digito = soma1 % 11;//Calcula o resto da divisão da soma por 11
            if (digito < 2)
            {
                digito = 0;
            }
            else
            {
                digito = 11 - digito;// Calcula o primeiro dígito verificador
            }
            
            if(Convert.ToInt32(cpf[9].ToString()) != digito)
            {
                return false;//Retorna falso se não for válido.
            }

            multiplicador = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma2 = 0;

            for (int i = 0; i < multiplicador.Length; i++)
            {
                soma2 += multiplicador[i] * (cpf[i] - '0');
            }
            
            int digito2 = soma2 % 11;//Calcula o resto da divisão da soma por 11

            if (digito2 < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - digito2;//Calcula o segundo dígito verificador
            }
            
            if (Convert.ToInt32(cpf[10].ToString()) != digito2)//Verifica se o segundo dígito verificador é igual ao dígito original do Cpf
            {
                return false;//retorna falso se não for válido
            }

            return true;//Retorna verdadeiro se o CPF for válido.
        }
        else 
        {
            return false;//retorna falso se o CPF não tiver 11 digidos
        }
    }
}