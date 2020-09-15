import React from 'react';
import { SafeAreaView, StyleSheet, TouchableOpacity, Image } from 'react-native';
import { images } from './ImagePath';

export default class App extends React.Component {

  state = {
    imageCount: 0
  };

  onPress = () => {
    var countNum = 0;
    if(this.state.imageCount < 2){
      countNum = this.state.imageCount + 1;
    }
    this.setState({
      imageCount: countNum
    });
  }

  render() {
    return (
      <SafeAreaView style={styles.container}>
        <TouchableOpacity
          onPress={this.onPress}
        >
          <Image
          style={styles.image}
          source={images.items[this.state.imageCount].req}
          />
        </TouchableOpacity>
      </SafeAreaView>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    marginTop: 100,
    marginLeft: 100,
  },
  image: {
    width: 200,
    height: 100,
    marginLeft: 10,
    marginTop: 10,
  }
});