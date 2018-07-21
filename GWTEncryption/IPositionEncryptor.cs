namespace GWTEncryption
{
    public interface IPositionEncryptor
    {
        string Encrypt(char message, int position);
        
    }
}