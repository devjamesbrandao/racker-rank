public static int diagonalDifference(List<List<int>> arr)
{
    var linhas = arr.Count - 1;
        
    var colunas = arr[0].Count - 1;

    int aux = colunas;

    var diagonalPrincipal = 0;

    var diagonalSecundaria = 0;

    for(var i = 0; i <= linhas; i++)
    {
        for(var j = 0; j <= colunas; j++)
        {
            if(i == j)
            {
                diagonalPrincipal += arr[i][j];
                diagonalSecundaria += arr[i][aux];
                aux--;
                break;
            }
        }
    }

    var diferenca = diagonalPrincipal - diagonalSecundaria;
    
    return diferenca < 0 ? diferenca * -1 : diferenca;
}