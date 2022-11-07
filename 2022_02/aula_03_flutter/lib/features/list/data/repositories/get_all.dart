import 'dart:io';

import 'package:aula_03_flutter/features/list/data/datasources/contracts/get_all.dart';
import 'package:aula_03_flutter/features/list/data/models/estado.dart';
import 'package:aula_03_flutter/core/failures.dart';
import 'dart:async';

import 'package:aula_03_flutter/features/list/domain/repositories/get_all.dart';
import 'package:dartz/dartz.dart';

class EstadoGetAllRepositoryImplementation
    extends EstadoGetAllRepositoryContract {
  final EstadoGetAllDatasourceContract datasource;

  EstadoGetAllRepositoryImplementation({
    required this.datasource,
  });

  @override
  FutureOr<Either<Failure, List<EstadoModel>>> getAll() async {
    try {
      return Right(await datasource.getAll());
    } on SocketException catch (e) {
      return Left(
        ServerFailure(
            message:
                'Servidor não está on-line, ou não existe conexão com a internet'),
      );
    }
  }
}
