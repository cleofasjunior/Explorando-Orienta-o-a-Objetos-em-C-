# Explorando Orientação a Objetos em C# 🚴‍♂️

## 📌 Introdução

Este projeto foi desenvolvido como parte do **bootcamp da Digital Innovation One (DIO)** com o objetivo de praticar e aprofundar os conceitos de **Programação Orientada a Objetos (POO) em C#**.
O sistema simula o monitoramento de bicicletas compartilhadas, calculando a **distância máxima estimada** que cada bicicleta pode percorrer com base no nível atual de bateria.

Cada **1% de bateria corresponde a 0,5 km** de autonomia.

## 📑 Sumário

* [Introdução](#-introdução)
* [Funcionalidades](#-funcionalidades)
* [Tecnologias Utilizadas](#-tecnologias-utilizadas)
* [Instalação](#-instalação)
* [Uso](#-uso)
* [Exemplos de Entrada e Saída](#-exemplos-de-entrada-e-saída)
* [Diagrama UML](#-diagrama-uml)
* [Habilidades e Aprendizados](#-habilidades-e-aprendizados)
* [Contribuidores](#-contribuidores)
* [Licença](#-licença)

## ⚙️ Funcionalidades

* Modelagem de uma bicicleta utilizando **POO**.
* Cálculo da **distância máxima estimada** de acordo com o nível da bateria.
* Entrada de dados via console (modelo e nível de bateria).
* Saída formatada em **mensagem padronizada** com uma casa decimal.

## 🛠️ Tecnologias Utilizadas

* **C#**
* **.NET SDK** (6.0 ou superior recomendado)
* IDE recomendada: Visual Studio / Visual Studio Code
* Plataforma de desenvolvimento: **Digital Innovation One (DIO)**

## 📥 Instalação

1. Clone este repositório:

   ```bash
   git clone https://github.com/seu-usuario/explorando-orientacao-objetos-csharp.git
   ```
2. Acesse a pasta do projeto:

   ```bash
   cd explorando-orientacao-objetos-csharp
   ```
3. Compile o projeto:

   ```bash
   dotnet build
   ```

## ▶️ Uso

Para executar o programa, utilize:

```bash
dotnet run
```

O programa irá solicitar:

1. O nome do modelo da bicicleta (**string**)
2. O nível atual da bateria (**int**)

## 📊 Exemplos de Entrada e Saída

| Entrada               | Saída                                     |
| --------------------- | ----------------------------------------- |
| `BikeX` <br> `80`     | `BikeX: Distancia estimada = 40.0 km`     |
| `UrbanRide` <br> `50` | `UrbanRide: Distancia estimada = 25.0 km` |
| `EcoBike` <br> `30`   | `EcoBike: Distancia estimada = 15.0 km`   |


## 📐 Diagrama UML

+-------------------------+
|        Bicicleta        |
+-------------------------+
| - Modelo: string        |
| - NivelBateria: int     |
+-------------------------+
| + Bicicleta(modelo,     |
|   nivelBateria)         |
| + CalcularDistancia():  |
|   double                |
| + ExibirMensagem():     |
|   string                |
+-------------------------+
```

Esse diagrama mostra a classe `Bicicleta`, seus atributos e métodos, representando a estrutura do projeto em termos de **POO**.

## 🚀 Habilidades e Aprendizados

Durante o desenvolvimento deste projeto, foram aplicados e aprimorados os seguintes conceitos de **Programação Orientada a Objetos (POO) em C#**:

* **Modelagem de Classes:** Criação da classe `Bicicleta`, representando o objeto principal do sistema.
* **Atributos:** Definição das propriedades da bicicleta, como `Modelo` e `NivelBateria`.
* **Métodos:** Implementação de um método para calcular a distância máxima estimada com base na regra de negócio (`1% = 0,5 km`).
* **Encapsulamento:** Organização do código para manter a lógica de cálculo dentro da classe, promovendo clareza e reutilização.
* **Instanciação de Objetos:** Criação de objetos a partir da classe `Bicicleta` para representar diferentes modelos.
* **Formatação de Saída:** Exibição de mensagens formatadas com **uma casa decimal**, garantindo clareza ao usuário.
* **Entrada e Validação de Dados:** Manipulação de valores fornecidos pelo usuário e uso de tipos adequados (`string` e `int`).

Esse projeto fortaleceu a base de **POO em C#**, preparando para desafios mais complexos que envolvem **herança, polimorfismo e abstração**.

## 👥 Contribuidores

* [**Cleófas Júnior**](https://github.com/cleofasjunior) - Desenvolvimento e documentação
* **Digital Innovation One (DIO)** - Plataforma de aprendizado

## 📄 Licença

Sinta-se livre para usar, modificar e distribuir este código.

---

👉 Quer que eu também prepare uma versão **gráfica do diagrama UML** (imagem gerada automaticamente a partir da descrição textual), para enriquecer ainda mais o README?
