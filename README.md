## CalculatorTDD
Projeto de calculo simples voltado ao estudo de testes de unidade (NUnit)

## Regras
A aplicação recebe 2 ou mais números e realiza a somatória dos mesmos, seguindo algumas exigencias que, deverao ser tratadas/ validadas via teste unitário (modelo NUnit)<ol>
 <li>A classe chamada CalculatorTDDProj terá um único método com a assinatura estática int Add(string numbers).</li>
 <li>O método pega uma string representando números separados por uma vírgula, e retorna sua soma.</li>
 <li>Se passarmos uma string vazia, o método deve retornar zero.</li>
 <li>A passagem de um único número deve resultar no próprio número.</li>
 <li>Se passarmos números negativos, o método deve lançar uma ArgumentException, com a mensagem "Números negativos não são permitidos para o cálculo:" seguida dos negativos que foram especificados.</li>
 <li>O método deve ignorar números maiores que 1000 devem. Portanto, “1.2.1000” deve resultar em 1003, mas “1.2.1001” deve resultar em 3.</li> 
</ol>

