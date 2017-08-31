using System.Text;

namespace T9Spelling
{
    public interface IConverter
    {
        StringBuilder Convert(string inputString);
    }
}