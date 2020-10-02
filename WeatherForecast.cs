using System;

namespace t_dotnetcore_webapi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}




{
  "clientes": [
    {
      "email": "fabricio@sunnit.com",
      "enderecos": [
        {
          "idEndereco": 0,
          "cep": 37500404,
          "logradouro": "Av. BPS",
          "numero": 1303,
          "bairro": "Pinheirinho",
          "cidade": "Itajubá",
          "estado": "MG",
          "tipoResidencia": "PROPRIO_QUITADO",
          "complemento": "Ap 01"
        }
      ],
      "telefones": [
        {
          "codigoProposta": "1",
          "idTelefone": 0,
          "ddd": 35,
          "numero": 36226262,
          "tipoTelefone": "RESIDENCIAL"
        }
      ],
      "compromisso": "PROPONENTE",
      "clientPF":
        {
          "nome": "José Pereira",
          "cpf": 60641362005,
          "rg": "13743644",
          "orgaoEmissorRG": "SSP",
          "ufEmissorRG": "MG",
          "dataEmissaoRG": "2020-01-01",
          "dataNascimento": "1990-01-01",
          "rendaMensal": 5000,
          "patrimonio": 500000,
          "cidadeNaturalidade": "Itajubá",
          "ufNaturalidade": "MG",
          "sexo": "MASCULINO",
          "escolaridade": "0",
          "nomeMae": "Maria Pereira",
          "estadoCivil": "SOLTEIRO",
          "cpfConjuge": 1520265689,
          "codigoOcupacao": 0
        }
      
    }
  ],
  "chaveExecucaoPricing": "B0A1D77C24D74BE7E0534700320AFC70",
  "prazo": 18,
  "enderecoInstalacao": {
    "idEndereco": 0,
    "cep": 37500404,
    "logradouro": "Av. BPS",
    "numero": 1303,
    "bairro": "Pinheirinho",
    "cidade": "Itajubá",
    "estado": "MG",
    "tipoResidencia": "PROPRIO_QUITADO",
    "complemento": "Apartamento 1"
  },
  "finalidadeProjeto": "Compra",
  "valorEquipamento": 40000,
  "valorInstalacao": 10000,
  "valorTotalProjeto": 50000,
  "propriedadesAdicionais": {
    "additionalProp1": "5555"
  }
}
