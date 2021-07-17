import React from "react";
import { View, Text, StyleSheet } from "react-native";

export const QrScreen = () => {
  return (
    <View style={styles.container}>
      <View style={styles.navigation}></View>
      <View style={styles.body}>
        <Text>Qr Screen</Text>
      </View>
      <View style={styles.footer}></View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "green",
  },
  navigation: {
    flex: 2,
    backgroundColor: "red",
  },
  body: {
    flex: 9,
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: "white",
  },
  footer: {
    flex: 1,
    backgroundColor: "cyan",
  },
});
