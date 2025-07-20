using Amazon.SimpleSystemsManagement;
using Common.Aws.Extensions;
using DapperDatabaseHelper.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DapperDatabaseHelper.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfigurationRoot configuration)
    {
        var connectionStringPath = configuration["MYSQL_CONNECTION_STRING_PATH"];

        return services
            .AddAwsServiceWithLocalSupport<IAmazonSimpleSystemsManagement>()
            .AddSingleton<ISqlConnectionFactory>(provider =>
                new MySqlConnectionFactory(
                    provider.GetRequiredService<IAmazonSimpleSystemsManagement>(),
                    connectionStringPath
                ));
    }

    public static IServiceCollection AddGenericDtoHandler<TDto, TKey>(this IServiceCollection services)
        where TDto : class
    {
        return services
            .AddSingleton<IGenericDtoStorage<TDto, TKey>, GenericDtoStorage<TDto, TKey>>();
    }
}