import 'dart:async';

import 'package:aula_03_flutter/core/failures.dart';
import 'package:aula_03_flutter/core/use_case.dart';
import 'package:aula_03_flutter/features/list/data/datasources/implementations/get_all.dart';
import 'package:aula_03_flutter/features/list/data/models/estado.dart';
import 'package:aula_03_flutter/features/list/data/repositories/get_all.dart';
import 'package:aula_03_flutter/features/list/domain/use_cases/get_all.dart';
import 'package:dartz/dartz.dart';

class EstadoGetAllController {
  Future<Either<Failure, List<EstadoModel>>> getAll() async {
    var result = await EstadoGetAllUseCase(
      repository: EstadoGetAllRepositoryImplementation(
        datasource: EstadoGetAllDataSourceImplementation(),
      ),
    )(NoParams());

    return result;
  }
}
