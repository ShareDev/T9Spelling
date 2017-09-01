namespace T9Spelling
{
    public class UnitOfWork : IUnitOfWork
    {
        private IConverter _converter;

        public IConverter Converter => _converter ?? (_converter = new StringConverter());
    }
}