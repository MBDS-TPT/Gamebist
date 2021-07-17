import React, { useState, useEffect } from "react";
import { View, Text, StyleSheet, TextInput } from "react-native";

interface SearchBarProps {
  onEndEditing?: any | undefined;
  didTouch?: any | undefined;
  autoFocus?: boolean | undefined;
  onTextChange: Function;
}

const SearchBar: React.FC<SearchBarProps> = ({
  onEndEditing,
  didTouch,
  autoFocus = false,
  onTextChange,
}) => {
  return (
    <View style={styles.container}>
      <TextInput
        style={styles.input}
        placeholder="Rechercher un match"
        autoFocus={autoFocus}
        onTouchStart={didTouch}
        onEndEditing={onEndEditing}
        onChangeText={(text) => onTextChange(text)}
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "green",
  },
  input: {
    height: 40,
    width: "100%",
    margin: 12,
    borderWidth: 1,
  },
});

export { SearchBar };
