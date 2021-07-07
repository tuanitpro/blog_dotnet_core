using System;

namespace Blog.Core.DataProvider
{
    public enum DataSourceProvider
    {
        Sql = 1,
        LocalDb = 2,
        MongoDb = 3
    }

    public interface DataProviderFactory
    {
        string GetConnectionString(DataSourceProvider dataSourceProvider);
    }
}