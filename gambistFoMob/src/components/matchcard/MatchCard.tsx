import React, { useState, useEffect } from "react";
import { View, Text, StyleSheet, TouchableHighlight } from "react-native";
import { Match } from "../../models/Model";

interface MatchCardProps {
  item: Match;
  onTap: Function;
}

const MatchCard: React.FC<MatchCardProps> = ({ item, onTap }) => {
  return (
    <View style={styles.container}>
      <Text>
        {item.teamA?.name} vs {item.teamB?.name}
      </Text>
      <TouchableHighlight onPress={() => onTap(item)}>
        <View style={styles.button}>
          <Text>Voir Détails</Text>
        </View>
      </TouchableHighlight>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "yellow",
  },
  button: {
    alignItems: "center",
    backgroundColor: "white",
    padding: 10,
  },
});

export { MatchCard };
