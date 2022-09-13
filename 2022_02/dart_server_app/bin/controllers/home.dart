import 'package:postgres/postgres.dart';
import 'package:shelf_router/shelf_router.dart';
import 'package:shelf/shelf.dart';

class HomeController {
  // Define our getter for our handler
  Handler get handler {
    final router = Router();

    // main route
    router.get('/', (Request request) async {
      var connection = PostgreSQLConnection("10.55.0.4", 5432, "postgres",
          username: "postgres", password: "utfpr");
      await connection.open();

      await connection.transaction((ctx) async {
        // var result = await ctx.query("SELECT id FROM table");
        await ctx.query(
            'INSERT INTO public."Cliente" (nome) VALUES (@nome:text)',
            substitutionValues: {"nome": 'TESTE'});
      });
      List<List<dynamic>> results =
          await connection.query('SELECT * FROM public."Cliente"');

      for (final row in results) {
        var a = row[0];
        var b = row[1];
      }

      return Response.ok('Hello World');
    });

    return router;
  }
}
