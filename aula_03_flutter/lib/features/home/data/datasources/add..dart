import 'dart:convert';

import 'package:http/http.dart' as http;

class AddEstadosDataSource {
  Future add() async {
    var url = Uri.http('localhost:5083', 'estados');
    var response = await http.post(
      url,
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
      },
      body: jsonEncode(<String, String>{
        "estadoID": '20',
        "uf": "MG",
        "nome": "Minas Gerais",
      }),
      //   headers: {
      //     "Content-Type": "application/x-www-form-urlencoded",
      //     "Accept": "application/json"
      //   },
      // body: {
      //   "estadoID": '20',
      //   "uf": "MG",
      //   "nome": "Minas Gerais",
      // },
    );

    // sleep(const Duration(seconds: 2));

    if (response.statusCode == 404) {
      // throw Exception();
    }
    if (response.statusCode == 200) {
      // return [];
      // List<dynamic> jsonDecoded = json.decode(response.body);
      // List<EstadoModel> result = [];

      // for (var element in jsonDecoded) {
      //   result.add(EstadoModel.fromJson(element));
      // }

      // return result;
    }

    // return [];
    // print(await http.read(Uri.https('example.com', 'foobar.txt')));
  }
}
