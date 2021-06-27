import React from 'react';
import { View, Text, Button } from 'react-native';

export default function HomeScreen({navigation}: {navigation: any}) {
    return (
      <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
        <Text>Home Screen</Text>
        <Button
            title="LOGIN"
            onPress={() => navigation.navigate('Login', {
                itemId: 86,
                otherParam: 'anything you want here',
            })}
        />
      </View>
    );
}