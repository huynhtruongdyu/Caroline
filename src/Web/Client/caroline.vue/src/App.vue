<template>
  <h2>{{ greate }} {{ name }}</h2>
  <div v-text="email"></div>
  <div v-html="decription"></div>
  <h2 v-bind:id="headingID">Heading 2</h2>
  <button v-bind:disabled="isDisable">Click me!</button>
  <h2 class="underline">This is underline text</h2>
  <h2 v-bind:class="status">Status</h2>
</template>

<script>
export default {
  name: "App",
  components: {},
  data() {
    return {
      greate: "Hello",
      name: "Duy",
      email: "huynhtruongdyu@gmail.com",
      decription: "<b>this is some decription</b>",
      headingID: "heading2",
      isDisable: true,
      status:"danger"
    };
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

.underline{
  text-decoration: underline;
}
</style>
