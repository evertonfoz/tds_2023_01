import 'package:aula_03_flutter/features/home/data/datasources/add..dart';
import 'package:aula_03_flutter/features/home/data/datasources/delete.dart';
import 'package:aula_03_flutter/features/home/data/datasources/get_all.dart';
import 'package:aula_03_flutter/features/home/data/model/estado.dart';
import 'package:flutter/material.dart';

class HomePage extends StatefulWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Estados'),
      ),
      body: FutureBuilder<List<EstadoModel>>(
        future: GetAllEstadosDataSource().getAll(),
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
          } else if (snapshot.hasData && (snapshot.data as List).isEmpty) {
            return const Center(
              child: Text('Sem estado'),
            );
          } else {
            List<EstadoModel> result = snapshot.data;
            return ListView.builder(
              itemCount: (snapshot.data as List).length,
              itemBuilder: (BuildContext context, int index) {
                return Dismissible(
                  confirmDismiss: ((direction) async {
                    if (direction == DismissDirection.startToEnd) {
                      await showDialog(
                          context: context,
                          builder: (context) {
                            return AlertDialog(
                              title: Text('Esquerda -> Direita'),
                              actions: [
                                TextButton(
                                  onPressed: () => Navigator.of(context).pop(),
                                  child: Text('OK'),
                                ),
                              ],
                            );
                          });
                      return Future.value(false);
                    } else {
                      await showDialog(
                          context: context,
                          builder: (context) {
                            return AlertDialog(
                              title: Text('Direita -> Esquerda'),
                              actions: [
                                TextButton(
                                  onPressed: () async {
                                    await DeleteEstadosDataSource()
                                        .delete(result[index].estadoID!);
                                    Navigator.of(context).pop();
                                  },
                                  child: Text('OK'),
                                ),
                              ],
                            );
                          });
                      return Future.value(true);
                    }
                  }),
                  background: Container(
                    color: Colors.red,
                    child: Row(
                        mainAxisAlignment: MainAxisAlignment.end,
                        children: const [
                          Text(
                            'Remover',
                            style: TextStyle(color: Colors.white),
                          ),
                          Icon(Icons.delete, color: Colors.white),
                        ]),
                  ),
                  key: UniqueKey(),
                  child: ListTile(
                    leading: Text(result[index].estadoID != null
                        ? result[index].estadoID.toString()
                        : ''),
                    title: Text(result[index].nome),
                    trailing: Text(result[index].uf),
                  ),
                );
              },
            );
          }
        },
      ),
      floatingActionButton: Column(
        mainAxisAlignment: MainAxisAlignment.end,
        children: [
          FloatingActionButton(
            onPressed: () async {
              await AddEstadosDataSource().add();
            },
            child: const Icon(
              Icons.add,
            ),
          ),
          FloatingActionButton(
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
