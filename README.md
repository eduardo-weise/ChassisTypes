# ChassisTypes

O projeto ChassisTypes é uma biblioteca C# que permite obter o tipo de gabinete do sistema em sistemas Windows e Linux.

## Instalação

Para instalar o ChassisTypes, você pode clonar o repositório do GitHub e compilar o projeto usando o .NET Core CLI.

```bash
git clone https://github.com/eduardo-weise/ChassisTypes.git
cd ChassisTypes
dotnet build
```

## Uso

Para usar o ChassisTypes em seu projeto, você pode adicionar uma referência ao pacote ChassisTypes em seu projeto.

```xml
<ItemGroup>
    <PackageReference Include="ChassisTypes" Version="1.0.0" />
</ItemGroup>
```

Depois de adicionar a referência, você pode usar o método `Get()` para obter o tipo de gabinete do sistema.

```csharp
using ChassisTypes.Chassis;

if (OperatingSystem.IsWindows())
{
    WindowsChassisTypes.Get();
}

if (OperatingSystem.IsLinux())
{
    LinuxChassisTypes.Get();
}
```

## Suporte

Este projeto é compatível com Windows e Linux. No entanto, o método `LinuxChassisTypes.Get()` depende do comando `dmidecode`, que pode não estar disponível em todos os sistemas Linux.

## Licença

Este projeto é licenciado sob a licença MIT.

## Contribuições

Contribuições são bem-vindas. Se você encontrar um bug ou tiver uma ideia para melhorar o ChassisTypes, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Créditos

Obrigado a todos os contribuidores do ChassisTypes!

---