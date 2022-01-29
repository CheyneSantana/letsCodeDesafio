# letsCodeDesafio

Para a geração e validação do Token, é necessário adicionar a secret no appsettings.json. Exemplo:
"Secret": {
    "Key": "ZWRpw6fDo28gZW0gY29tcHV0YWRvcmE="
  }

Para realizar o login, é necessário adicionar novos campos (em negrito) na tag "Secret" em appsettings.json. Exemplo:
"Secret": {
    "Key": "ZWRpw6fDo28gZW0gY29tcHV0YWRvcmE=",
    **"Login": "letscode",**
    **"Senha": "lets@123"**
  }

Caso utilize o Swagger para os testes na API, após realizar o login, copie o token gerado e clique no botão * *Authorize* * ![Authorize button](https://drive.google.com/file/d/1C5jAbDKyEvjsAAFVosXko7Q8UhmPLt_5/view?usp=sharing)
irá abrir uma janela, basta adicionar no campo "Value" Bearer + seu token, como mostrado no exemplo e depois clicar em Authorize. Assim toda requisição 
irá utilizar o token informado.
![Authorize window](https://drive.google.com/file/d/1Jroqf4szIwhL2vqF-DFpY6UBHU4_ReGe/view?usp=sharing)
