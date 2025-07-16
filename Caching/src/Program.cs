using System.Collections;

async Task<string> GetDadosServer(string url)
{
    try
    {
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var body = await response.Content.ReadAsStringAsync();

        return body;
    }
    catch (Exception ex)
    {
        throw new Exception(ex.Message);
    }
}

var cache = new Hashtable();
async Task<object> Cache(string url)
{
    try
    {
        if (cache.ContainsKey(url))
        {
            Console.WriteLine("Já está no cache!");
            return cache[url];
        }
        else
        {
            Console.WriteLine("Adicionando ao cache!");
            var body = await GetDadosServer(url);
            cache[url] = body;
            return body;
        }
    }
    catch (Exception ex)
    {
        throw new Exception(ex.Message);
    }
}

try
{
    Console.WriteLine("Primeiro acesso...");
    var resposta = await Cache("https://google.com");
    Console.WriteLine("Verificando se está no cache...");
    var response2 = await Cache("https://google.com");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
