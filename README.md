# 📚 Biblioteca Digital em C#  

Este é um **aplicativo de console desenvolvido em C# (.NET 8)** como uma **biblioteca digital interativa** para organizar, avaliar e consultar informações sobre livros e autores.  

O projeto consolida **cinco módulos distintos**, cada um abordando uma funcionalidade específica relacionada a livros, acessíveis através de um **menu interativo**.  

---

## 📋 Módulos Incluídos  

### 1️⃣ Verificador de ISBN  
- **Objetivo:** Validar se o código ISBN de um livro é correto.  
- **Funcionalidade:**  
  - Solicita ao usuário que digite o código ISBN do livro.  
  - Verifica se o ISBN possui **13 dígitos numéricos**.  
  - Exibe mensagens claras de **válido ou inválido**.  

---

### 2️⃣ Classificador de Gênero Literário  
- **Objetivo:** Classificar livros de acordo com seu gênero.  
- **Funcionalidade:**  
  - Solicita o nome do livro.  
  - Solicita o gênero do livro (**Ficção, Fantasia, Mistério, Biografia, etc.**)  
  - Exibe mensagem indicando o livro e o gênero classificado.  

---

### 3️⃣ Disponibilidade para Empréstimo  
- **Objetivo:** Verificar se um livro pode ser emprestado.  
- **Funcionalidade:**  
  - Solicita o título do livro.  
  - Pergunta se o livro está disponível (**true/false**).  
  - Exibe mensagem indicando se o livro pode ou não ser emprestado.  

---

### 4️⃣ Avaliador de Avaliações  
- **Objetivo:** Calcular a média das avaliações de um livro.  
- **Funcionalidade:**  
  - Solicita **três notas de avaliação (0 a 10)**.  
  - Valida cada nota, ignorando entradas inválidas.  
  - Calcula e exibe a **média das avaliações** com duas casas decimais.  

---

### 5️⃣ Reconhecedor de Autores Famosos  
- **Objetivo:** Identificar se um autor é famoso.  
- **Funcionalidade:**  
  - Solicita o nome do autor.  
  - Verifica se o autor pertence a uma lista predefinida:  
    - *J.K. Rowling*  
    - *George R.R. Martin*  
    - *J.R.R. Tolkien*  
    - *Agatha Christie*  
  - Exibe mensagem indicando se o autor é famoso ou não listado.  

---

## ⚙️ Execução do Projeto  

### 🛠️ Tecnologias Utilizadas  
- **Linguagem:** C#  
- **Plataforma:** .NET 8  
- **Bibliotecas:** Apenas bibliotecas padrão do .NET (`System.Text.Json`)  
- **Dependências externas:** Nenhuma  

---

### 📦 Pré-requisitos  
Para compilar e executar este projeto, você precisará ter o SDK do **.NET 8** (ou superior) instalado em sua máquina.  

👉 [Download do .NET 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)  

---

### 🚀 Como Executar  

No terminal, siga os passos abaixo:  

```bash
# 1. Clone este repositório
git clone https://github.com/Hamewolf/Trabalho_AV1_Computacao.git

# 2. Acesse a pasta do projeto
cd Trabalho_AV1_Computacao

# 3. Compile o projeto
dotnet build

# 4. Execute o projeto
dotnet run
