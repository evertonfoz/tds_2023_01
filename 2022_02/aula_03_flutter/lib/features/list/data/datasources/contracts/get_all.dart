import 'dart:async';

import 'package:aula_03_flutter/features/list/data/models/estado.dart';

abstract class EstadoGetAllDatasourceContract {
  Future<List<EstadoModel>> getAll();
}
