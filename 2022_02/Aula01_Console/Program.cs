HttpClient client = new();
client.BaseAddress = new Uri("http://localhost:5073");


    using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "/weatherforecast"))
    {
        using (HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
        {
            response.EnsureSuccessStatusCode();
             var teste = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        Console.WriteLine(teste);
        }
    }
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
