import React, { useEffect, useState } from "react";
import { View, Text, StyleSheet, ScrollView, FlatList } from "react-native";
import { CategoryButton } from "../components/button/CategoryButton";
import { SearchBar } from "../components/searchbar/SearchBar";
import { CategoryService } from "../services/category/category.service";
import { useNavigation } from "../utils/useNavigation";
interface HomeProps {
  categories: any;
}
export const HomeScreen: React.FC<HomeProps> = (props) => {
  const { navigate } = useNavigation();
  const [errorMessage, setErrorMessage] = useState<string>();

  const { categories } = props.categories;

  useEffect(() => {
    CategoryService.getCategories()
      .then((res) => {
        console.log("ok category");
        let categArranged = [
          {
            id: -1,
            label: "All sports",
            state: 0,
          },
          ...(res || []),
        ];
        props.categories = categArranged || [];
      })
      .catch((error) => {
        setErrorMessage(error + "");
      });
  }, []);

  return (
    <View style={styles.container}>
      <View style={styles.navigation}>
        <SearchBar onTextChange={() => {}} />
        <ScrollView>
          <FlatList
            horizontal
            showsHorizontalScrollIndicator={false}
            data={categories}
            renderItem={({ item }) => (
              <CategoryButton
                item={item}
                onTap={() => {
                  alert("category taped");
                }}
              />
            )}
          />
        </ScrollView>
      </View>
      <View style={styles.body}>
        <Text>Match Screen</Text>
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
