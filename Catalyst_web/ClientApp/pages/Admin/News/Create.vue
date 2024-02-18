<template>
  <div>
    <form @submit.prevent="create" action="/assets/inc/sendemail.php" >
      <input v-model="createData.titleArm" type="text" placeholder="Title in Armenian" name="titleArm">
      <input v-model="createData.titleEng" type="text" placeholder="Title in english" name="titleEng">
      <input v-model="createData.descriptionArm" type="text" placeholder="Description in Armenian" name="descriptionArm">
      <input v-model="createData.descriptionEng" type="text" placeholder="Description in english" name="descriptionEng">
      <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
    </form><!-- /.become-teacher__form-content -->
  </div>

</template>

<script>
  import https from 'https';
  export default {
    name: 'CreateNews',
    setup() {
      return {
        createData: { titleArm: '',titleEng: '', descriptionArm: '', descriptionEng: '' },
      };
    },
    methods: {
      async create() {
        try {
          await this.$axios.post('/api/News/Create', this.createData)
          // Show success message
            .then(function (response) {
              if (response) {
                window.location = "/admin/News/List"
              }
            })
            .catch(function (error) {
              
            })
        } catch (error) {
          // Handle error and display message
        }
      },
    },
    created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  }
</script>
