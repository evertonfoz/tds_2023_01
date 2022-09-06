import 'dart:convert';
import 'dart:io';

import 'package:aula_03_flutter/features/home/data/model/estado.dart';
import 'package:http/http.dart' as http;

class GetAllEstadosDataSource {
  Future<List<EstadoModel>> getAll() async {
    var url = Uri.http('localhost:5299', 'api/estados');
    var response = await http.get(url);

    // sleep(const Duration(seconds: 2));

    if (response.statusCode == 404) {
      throw Exception();
    }
    if (response.statusCode == 200) {
      // return [];
      List<dynamic> jsonDecoded = json.decode(response.body);
      List<EstadoModel> result = [];

      for (var element in jsonDecoded) {
        result.add(EstadoModel.fromJson(element));
      }

      return result;
    }
    print('Response status: ${response.statusCode}');
    print('Response body: ${response.body}');

    return [];
    // print(await http.read(Uri.https('example.com', 'foobar.txt')));
  }
}
