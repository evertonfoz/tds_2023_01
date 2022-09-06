import 'package:aula_03_flutter/features/home/data/datasources/add..dart';
import 'package:aula_03_flutter/features/home/data/datasources/update.dart';
import 'package:aula_03_flutter/features/home/data/model/estado.dart';
import 'package:flutter/material.dart';

class EstadoCRUDPage extends StatefulWidget {
  final EstadoModel? estadoModel;

  EstadoCRUDPage({
    Key? key,
    this.estadoModel,
  }) : super(key: key);

  @override
  State<EstadoCRUDPage> createState() => _EstadoCRUDPageState();
}

class _EstadoCRUDPageState extends State<EstadoCRUDPage> {
  final TextEditingController _ufController = TextEditingController();

  final TextEditingController _nomeController = TextEditingController();

  @override
  void initState() {
    if (widget.estadoModel != null) {
      _ufController.text = widget.estadoModel!.uf;
      _nomeController.text = widget.estadoModel!.nome;
    }
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(),
      body: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            TextFormField(
              controller: _ufController,
              // onChanged: (value) => _uf = value,
              decoration: InputDecoration(
                  // border: UnderlineInputBorder(
                  //     borderSide: BorderSide(color: Colors.red, width: 2)),
                  enabledBorder: const OutlineInputBorder(
                    borderSide: BorderSide(color: Colors.indigo),
                  ),
                  focusedBorder: UnderlineInputBorder(
                      borderSide:
                          BorderSide(color: Colors.indigo.shade500, width: 2)),
                  errorBorder: InputBorder.none,
                  disabledBorder: InputBorder.none,
                  contentPadding:
                      EdgeInsets.only(left: 15, bottom: 11, top: 11, right: 15),
                  hintText: 'UF'),
            ),
            TextFormField(
              controller: _nomeController,
              // onChanged: (value) => _nome = value,
            ),
            const SizedBox(height: 30),
            ElevatedButton(
                onPressed: () async {
                  if (widget.estadoModel == null) {
                    // await AddEstadosDataSource().add(uf: _uf, nome: _nome);
                  } else {
                    await UpdateEstadosDataSource().update(
                      estadoModel: EstadoModel(
                          estadoID: widget.estadoModel!.estadoID,
                          uf: _ufController.text,
                          nome: _nomeController.text),
                    );
                  }

                  showDialog(
                    barrierDismissible: false,
                    context: context,
                    builder: (BuildContext context) {
                      return AlertDialog(
                        title: const Text('Feito'),
                        actions: [
                          TextButton(
                            onPressed: () {
                              Navigator.of(context).pop();
                            },
                            child: const Text('OK'),
                          )
                        ],
                      );
                    },
                  );
                },
                child: Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: const [
                      Icon(Icons.check),
                      SizedBox(
                        width: 8,
                      ),
                      Text('Acessar'),
                    ]))
          ],
        ),
      ),
    );
  }
}
