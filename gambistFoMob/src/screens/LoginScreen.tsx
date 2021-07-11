import React, { useState } from "react";
import {
  View,
  Text,
  StyleSheet,
  Image,
  TouchableHighlight,
  TextInput,
} from "react-native";
import { UserService } from "../services/user/user.service";
import { useNavigation } from "../utils/useNavigation";

export const LoginScreen = () => {
  const [username, setUsername] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [errorMessage, setErrorMessage] = useState<string>();

  const { navigate } = useNavigation();

  const onLogin = () => {
    UserService.login(username, password)
      .then((res) => {
        console.log("ok boy");
        if (res.message == "OK") {
          navigate("homeStack");
        } else {
          setErrorMessage(res.message);
        }
      })
      .catch((error) => {
        setErrorMessage(error + "");
      });
  };

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
          onChangeText={setUsername}
          placeholder="Login"
          textContentType="emailAddress"
        />
        <TextInput
          style={styles.input}
          onChangeText={setPassword}
          secureTextEntry={true}
          textContentType="password"
        />
        <TouchableHighlight onPress={onLogin}>
          <View style={styles.button}>
            <Text>Se connecter</Text>
          </View>
        </TouchableHighlight>
        {errorMessage && (
          <Text style={styles.errorMessage}>{errorMessage}</Text>
        )}
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
  errorMessage: {
    color: "red",
  },
});
