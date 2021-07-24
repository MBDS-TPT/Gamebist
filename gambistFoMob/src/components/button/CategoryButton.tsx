import React, { useState, useEffect } from "react";
import {
  View,
  Text,
  StyleSheet,
  TextInput,
  TouchableHighlight,
} from "react-native";
import { Category } from "../../models/Model";

interface CategoryButtonProps {
  item: Category;
  onTap: Function;
}

const CategoryButton: React.FC<CategoryButtonProps> = ({ item, onTap }) => {
  return (
    <TouchableHighlight onPress={() => onTap(item)}>
      <View style={styles.button}>
        <Text>{item.label}</Text>
      </View>
    </TouchableHighlight>
  );
};

const styles = StyleSheet.create({
  button: {
    alignItems: "center",
    backgroundColor: "white",
    padding: 15,
  },
});

export { CategoryButton };
