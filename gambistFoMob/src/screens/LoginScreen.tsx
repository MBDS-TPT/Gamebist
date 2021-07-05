import React, { useState } from "react";
import {
  View,
  Text,
  StyleSheet,
  Image,
  TouchableHighlight,
  TextInput,
} from "react-native";

import { useNavigation } from "../utils/useNavigation";

export const LoginScreen = () => {
  const [username, setUsername] = useState<string>();
  const [password, setPassword] = useState<string>();

  const onChangeUsername = (e: any) => {
    setUsername(e.target.value);
  };

  const onChangePassword = (e: any) => {
    setPassword(e.target.value);
  };

  const { navigate } = useNavigation();

  const onPress = () => navigate("homeStack");

  return (
    <View style={styles.container}>
      <View style={styles.navigation}>
        <Image
          source={require("../../assets/favicon.png")}
          style={styles.imageHeader}
        />
      </View>
      <View style={styles.body}>
        <Text>Gambist</Text>
        <Text>Login Screen</Text>
        <TextInput
          style={styles.input}
          onChangeText={onChangeUsername}
          placeholder="Login"
          textContentType="emailAddress"
        />
        <TextInput
          style={styles.input}
          onChangeText={onChangePassword}
          secureTextEntry={true}
          textContentType="password"
        />
        <TouchableHighlight onPress={onPress}>
          <View style={styles.button}>
            <Text>Aller au menu</Text>
          </View>
        </TouchableHighlight>
      </View>
      <View style={styles.footer}></View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "white",
  },
  navigation: {
    flex: 2,
    justifyContent: "flex-end",
    alignItems: "center",
  },
  body: {
    flex: 9,
    alignItems: "center",
    marginTop: 20,
  },
  imageHeader: {
    width: 50,
    height: 50,
  },
  button: {
    alignItems: "center",
    backgroundColor: "#DDDDDD",
    padding: 10,
  },
  footer: {
    flex: 1,
  },
  input: {
    height: 40,
    width: "100%",
    margin: 12,
    borderWidth: 1,
  },
});
