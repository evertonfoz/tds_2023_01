import 'package:aula_02_flutter/homepage.dart';
import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';

class LoginPage extends StatelessWidget {
  LoginPage({Key? key}) : super(key: key);
  String? userLogin;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      // backgroundColor: Colors.orange,
      body: Stack(
        children: [
          SizedBox(
            height: MediaQuery.of(context).size.height,
            child: Opacity(
              opacity: 0.2,
              child: Image.network(
                  fit: BoxFit.cover,
                  'http://www.utfpr.edu.br/noticias/medianeira/arte-e-cultura/FAZENDOARTE1.jpg'),
            ),
          ),
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                const Text(
                  'Digite seu usuário:',
                  // textAlign: TextAlign.left,
                ),
                TextField(
                  onChanged: ((value) {
                    userLogin = value;
                    debugPrint(value);
                  }),
                  textInputAction: TextInputAction.go,
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 18.0),
                  child: ElevatedButton(
                      onPressed: () async {
                        final int value = await Navigator.push(
                          context,
                          MaterialPageRoute(
                              builder: (context) => HomePage(
                                    title: 'Homepage',
                                    initialValue: 10,
                                    userName: userLogin ?? '',
                                  )),
                        );

                        showDialog(
                          barrierDismissible: false,
                          context: context,
                          builder: (BuildContext context) {
                            return AlertDialog(
                              title: Text('$value'),
                              actions: [
                                TextButton(
                                  onPressed: () {
                                    Navigator.of(context).pop();
                                  },
                                  child: Text('OK'),
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
                        ],
                      )),
                ),
                CachedNetworkImage(
                  imageUrl:
                      "http://www.utfpr.edu.br/noticias/medianeira/arte-e-cultura/FAZENDOARTE1.jpg",
                  progressIndicatorBuilder: (context, url, downloadProgress) =>
                      CircularProgressIndicator(
                          value: downloadProgress.progress),
                  errorWidget: (context, url, error) => Icon(Icons.error),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
