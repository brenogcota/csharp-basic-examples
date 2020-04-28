// Condicionais
double saldo = 100.0;
double valorSaque = 10.0;

if (saldo >= valorSaque)
{
    saldo = saldo - valorSaque;
    MessageBox.Show("Saque realizado com sucesso");
}


// Estrutura de repetição
double valorInvestimento = 1000.0;
for (int i = 1; i <= 12; i++)
{
    valorInvestimento = valorInvestimento * 1.01;
}

MessageBox.Show("Valor investido agora é " + valorInvestimento);

int i = 1;

while(i <= 12)
{
    valorInvestimento = valorInvestimento * 1.01;
    i += 1;
}

MessageBox.Show("Valor investido agora é " + valorInvestimento);
