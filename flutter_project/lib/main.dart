import 'package:flutter/material.dart';
void main() => runApp(MyApp());
class MyApp extends StatelessWidget {

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: MyHomePage(title: 'Change Image'),
    );
  }
}
class MyHomePage extends StatefulWidget {
  MyHomePage({Key key, this.title}) : super(key: key);
  final String title;
  @override
  _MyHomePageState createState() => _MyHomePageState();
}
class _MyHomePageState extends State<MyHomePage> {

  final String path = 'assets/images/image00';
  String imagePath = 'assets/images/image001.jpg';
  int count = 1;
  final int maxCount = 3;

  void changeImage(){
    count++;

    if(maxCount < count){
      count = 1;
    }

    setState(() {
      imagePath = path + count.toString() + '.jpg';
    });
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
      ),
      body: GestureDetector(
        onTap: () => changeImage(),
        child: Image.asset(imagePath),
      ),
    );
  }
}