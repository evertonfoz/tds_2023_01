import 'package:aula_03_flutter/core/failures.dart';
import 'package:aula_03_flutter/features/list/controllers/get_all.dart';
import 'package:aula_03_flutter/features/list/data/models/estado.dart';
import 'package:dartz/dartz.dart' as dartz;
import 'package:flutter/material.dart';

class ListPage extends StatefulWidget {
  const ListPage({Key? key}) : super(key: key);

  @override
  State<ListPage> createState() => _ListPageState();
}

class _ListPageState extends State<ListPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Estados'),
      ),
      body: FutureBuilder<dartz.Either<Failure, List<EstadoModel>>>(
        future: EstadoGetAllController().getAll(),
        // initialData: [],
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(
              child: CircularProgressIndicator(
                backgroundColor: Colors.amber,
                color: Colors.black,
              ),
            );
          } else if (snapshot.hasError) {
            return const Center(
              child: Text('Erro'),
            );
          } else if (snapshot.hasData) {
            late Widget widgetToShow;
            snapshot.data.fold((failure) {
              widgetToShow = Center(
                child: Text(failure.message),
              );
            }, (result) {});

            return widgetToShow;

            // if (snapshot.data[0].runtimeType == Failure) {
            //   return Center(
            //     child: Text(snapshot.data.toString()),
            //   );
            // }
          } else if (snapshot.hasData && (snapshot.data as List).isEmpty) {
            return const Center(
              child: Text('Sem estado'),
            );
            // } else {
            //   List<EstadoModel> result = snapshot.data;
            //   return ListView.builder(
            //     itemCount: (snapshot.data as List).length,
            //     itemBuilder: (BuildContext context, int index) {
            //       return Dismissible(
            //         confirmDismiss: ((direction) async {
            //           if (direction == DismissDirection.startToEnd) {
            //             await showDialog(
            //                 context: context,
            //                 builder: (context) {
            //                   return AlertDialog(
            //                     title: const Text('Esquerda -> Direita'),
            //                     actions: [
            //                       TextButton(
            //                         onPressed: () => Navigator.of(context).pop(),
            //                         child: const Text('OK'),
            //                       ),
            //                     ],
            //                   );
            //                 });
            //             return Future.value(false);
            //           } else {
            //             await showDialog(
            //                 context: context,
            //                 builder: (context) {
            //                   return AlertDialog(
            //                     title: const Text('Direita -> Esquerda'),
            //                     actions: [
            //                       TextButton(
            //                         onPressed: () async {
            //                           // await DeleteEstadosDataSource()
            //                           //     .delete(result[index].estadoID!);
            //                           // Navigator.of(context).pop();
            //                         },
            //                         child: const Text('OK'),
            //                       ),
            //                     ],
            //                   );
            //                 });
            //             return Future.value(true);
            //           }
            //         }),
            //         background: Container(
            //           color: Colors.red,
            //           child: Row(
            //               mainAxisAlignment: MainAxisAlignment.end,
            //               children: const [
            //                 Text(
            //                   'Remover',
            //                   style: TextStyle(color: Colors.white),
            //                 ),
            //                 Icon(Icons.delete, color: Colors.white),
            //               ]),
            //         ),
            //         key: UniqueKey(),
            //         child: InkWell(
            //           child: ListTile(
            //             onTap: () async {
            //               // await Navigator.push(
            //               //   context,
            //               //   MaterialPageRoute(
            //               //       builder: (context) => EstadoCRUDPage(
            //               //             estadoModel: EstadoModel(
            //               //                 estadoID: result[index].estadoID,
            //               //                 uf: result[index].uf,
            //               //                 nome: result[index].nome),
            //               //           )),
            //               // );
            //               // setState(() {});
            //             },
            //             leading: Text(result[index].estadoID != null
            //                 ? result[index].estadoID.toString()
            //                 : ''),
            //             title: Text(result[index].nome),
            //             trailing: Text(result[index].uf),
            //           ),
            //         ),
            //       );
            //     },
            //   );
          }
          return (Container());
        },
      ),
      floatingActionButton: Column(
        mainAxisAlignment: MainAxisAlignment.end,
        children: [
          FloatingActionButton(
            heroTag: 'Add',
            onPressed: () async {
              // await Navigator.push(
              //   context,
              //   MaterialPageRoute(builder: (context) => EstadoCRUDPage()),
              // );
              // setState(() {});
            },
            child: const Icon(
              Icons.add,
            ),
          ),
          FloatingActionButton(
            heroTag: 'Refresh',
            backgroundColor: Colors.green,
            onPressed: () {
              setState(() {});
            },
            child: const Icon(
              Icons.refresh,
            ),
          ),
        ],
      ),
    );
  }
}
