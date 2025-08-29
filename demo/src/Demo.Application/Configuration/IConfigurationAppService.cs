using Demo.Configuration.Dto;
using System.Threading.Tasks;

namespace Demo.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
